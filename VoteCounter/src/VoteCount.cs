using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Globalization;

namespace VoteCounter
{
    class VoteCount
    {
        public System.Collections.Specialized.OrderedDictionary rawVoteCount { get; set; }

        //will have a number for each player, followed by a List<string> of names players may go by. List can be accessed in Player.
        public System.Collections.Specialized.OrderedDictionary playerNames { get; set; }        

        public List<string> playerList { get; set; }

        public VoteCount(List<string> playerList)
        {
            rawVoteCount = new System.Collections.Specialized.OrderedDictionary();
            this.playerList = playerList;
        }

        /*parses list, looking for unvotes, then votes*/
        /*NOTE: I only did this because of similarity between findVotes and FindVotes, for my sanity*/
        public void FindVotes(List<Post> PostList)
        {
            foreach (Post post in PostList)
            {
                findUnvotes(post);
                findVotes(post);
            }
        }
        /*parses post for unvotes*/
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
        /*parses post for votes*/
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
            return playerList.Contains(vote);
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
            foreach(string name in playerList)
            {
                if (!rawVoteCount.Contains(name))
                {
                    notVoting.Add(name);
                }
            }

            voteCount.Add("Not Voting", notVoting);

            //TODO: Sort
            return voteCount;
        }

        //
        public void populatePlayerNicknameList(List<string> a_playerList)
        {
            int playerCounter = 0;

            for(int i = 0; i < a_playerList.Count(); ++i)
            {
                Player p = new Player(playerCounter++, a_playerList.ElementAt(i));
            }

        }
    }
}
