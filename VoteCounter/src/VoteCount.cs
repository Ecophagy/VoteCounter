using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace VoteCounter
{
    class VoteCount
    {
        public System.Collections.Specialized.OrderedDictionary rawVoteCount { get; set; }

        public List<Player> playerList { get; set; }

        public VoteCount(List<Player> playerList)
        {
            rawVoteCount = new System.Collections.Specialized.OrderedDictionary();
            this.playerList = playerList;
        }

        public void FindVotes(List<Post> PostList)
        {
            foreach (Post post in PostList)
            {
                findUnvotes(post);
                findVotes(post);
            }
        }

        private void findUnvotes(Post post)
        {
            string pattern = "<strong>unvote</strong>";
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                                    post.text,
                                    pattern,
                                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (match.Success)
            {
                //Is the poster already voting? If they are, remove their vote
                if (rawVoteCount.Contains(post.poster))
                {
                    rawVoteCount.Remove(post.poster);
                }
            }

        }

        private void findVotes(Post post)
        {
            string pattern = "<strong>vote:? (.+)</strong>";
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                                    post.text,
                                    pattern,
                                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string vote = match.Groups[1].Value;
                string votee;

                //Is the vote for a real votee?
                if (isVoteValid(post.poster, vote, out votee))
                {
                    //Is the poster already voting? If they are, remove their vote
                    if (rawVoteCount.Contains(post.poster))
                    {
                        rawVoteCount.Remove(post.poster);
                    }

                    //Add the vote to the votecount
                    rawVoteCount.Add(post.poster, votee);
                }
                else
                {
                    Console.WriteLine("Invalid vote in post #" + post.postNumber);
                }
            }
        }

        private bool isVoteValid(string voter, string vote, out string votee)
        {
            return (isVoteeValid(vote, out votee) && isVoterValid(voter));
        }

        private bool isVoteeValid(string vote, out string votee)
        {
            foreach (Player p in playerList)
            {
                //check to see if the player being voted for is on the playerlist
                if (String.Compare(vote, p.mainName, true) == 0)
                {
                    votee = p.mainName;
                    return true;
                }
                else
                {
                    foreach (string nickname in p.nicknameList)
                    {
                        //or if it has a nickname in the list
                        if (String.Compare(vote, nickname, true) == 0)
                        {
                            votee = p.mainName;
                            return true;
                        }

                    }
                }
            }

            //Not voting for a vlaid player, so check for "no lynch" votes
            if ((new[] { "No Lynch", "NoLynch" }).Contains(vote, StringComparer.OrdinalIgnoreCase))
            {
                votee = "No Lynch";
                return true;
            }

            //Still no valid vote, so return false
            votee = null;
            return false;
        }

        private bool isVoterValid(string voter)
        {
            //A votee is only valid if they are on the playerlist
            foreach (Player p in playerList)
            {
                if(String.Compare(voter, p.mainName, false) == 0) //Case insensitive because it needs to exactly match MTGS username
                {
                    return true;
                }
            }
            return false;
        }


        //Create a votecount where key is votee and value is list of players voting for that player
        public SortedDictionary<string, List<string>> createVotecount()
        {
            var voteCount = new SortedDictionary<string, List<string>>();
            foreach(DictionaryEntry kvp in rawVoteCount)
            {
                //If this is the first vote on the votee, add them to the dictionary
                if(!voteCount.ContainsKey((string)kvp.Value))
                {
                    voteCount.Add((string)kvp.Value, new List<string> { (string)kvp.Key });
                }
                //If we've seen them before, add this new vote against them
                else
                {
                    voteCount[(string)kvp.Value].Add((string)kvp.Key);
                }
            }

            List<string> notVoting = new List<string>();

            //List Not Voting
            foreach(Player player in playerList)
            {
                if (!rawVoteCount.Contains(player.mainName))
                {
                    notVoting.Add(player.mainName);
                }
            }

            voteCount.Add("Not Voting", notVoting);

            //TODO: Sort
            return voteCount;
        }
    }
}
