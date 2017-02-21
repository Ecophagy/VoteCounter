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

        //public VoteCount(List<string> playerList)
        //{
        //    rawVoteCount = new System.Collections.Specialized.OrderedDictionary();
        //    this.playerList = playerList;
        //}

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
                    //Is the poster already voting? If they are, remove their vote
                    if (rawVoteCount.Contains(post.poster))
                    {
                        rawVoteCount.Remove(post.poster);
                    }
                    rawVoteCount.Add(post.poster, match.Groups[1].Value);
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
                if (p.mainName.Equals(vote) || p.nicknameList.Contains(vote))
                    return true;
            }
            return false;
            //return playerList.Contains(vote);
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
