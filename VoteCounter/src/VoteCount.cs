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
                if (isVoteValid(match.Groups[1].Value))
                {

                    string foundPlayer = "";
                    //Is the poster already voting? If they are, remove their vote
                    if (rawVoteCount.Contains(post.poster))
                    {
                        rawVoteCount.Remove(post.poster);
                    }

                    foreach (Player p in playerList)
                    {
                        string toMatch = match.Groups[1].Value;
                        //check to see if the person the player is voting for is that player's full name
                        if(String.Compare(p.mainName, toMatch, true) == 0 )
                        {
                            foundPlayer = p.mainName;
                            break;
                        }
                        if (p.nicknameList.Count > 0)
                        {
                           
                            for (int i = 0; i < p.nicknameList.Count; i++)
                            {
                                //or if it's one of the allowed nicknames
                                if (String.Compare(p.nicknameList[i], toMatch, true) == 0)
                                {
                                    foundPlayer = p.mainName;
                                    break;
                                }

                            }
                        }
                    }
                    if (foundPlayer != "")
                    {
                        rawVoteCount.Add(post.poster, foundPlayer);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid vote in post #" + post.postNumber);
                }
            }
        }


        private bool isVoteValid(string vote)
        {
            foreach(Player p in playerList)
            {
                //check to see if the player being voted for is on the playerlist
                if (String.Compare(vote, p.mainName, true) == 0)
                {
                    return true;
                }
                else if (p.nicknameList.Count > 0)
                {
                    for (int i = 0; i < p.nicknameList.Count; i++)
                    {
                        //or if it has a nickname in the list
                        if (String.Compare(vote, p.nicknameList[i], true) == 0)
                            return true;
                    }
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
