using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace VoteCounter
{
    class VoteCount
    {
        public System.Collections.Specialized.OrderedDictionary RawVoteCount { get; set; }

        public List<Player> PlayerList { get; set; }
        private Logger logger;

        public VoteCount(List<Player> playerList, Logger logger)
        {
            RawVoteCount = new System.Collections.Specialized.OrderedDictionary();
            this.PlayerList = playerList;
            this.logger = logger;
        }

        public void FindVotes(List<Post> PostList)
        {
            foreach (Post post in PostList)
            {
                FindUnvotes(post);
                FindVotes(post);
            }
        }

        private void FindUnvotes(Post post)
        {
            string pattern = "<strong>unvote</strong>";
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                                    post.Text,
                                    pattern,
                                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (match.Success)
            {
                //Is the poster already voting? If they are, remove their vote
                if (RawVoteCount.Contains(post.Poster))
                {
                    RawVoteCount.Remove(post.Poster);
                }
            }
        }

        private void FindVotes(Post post)
        {
            string pattern = "<strong>(?:unvote[,.]?)? ?vote:? (.+)</strong>";
            System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                                    post.Text,
                                    pattern,
                                    System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            if (match.Success)
            {
                string vote = match.Groups[1].Value;
                string voter = post.Poster;

                if (IsVoterValid(voter))
                {
                    if (IsVoteeValid(vote, out string votee))
                    {
                        //Is the poster already voting? If they are, remove their vote
                        if (RawVoteCount.Contains(voter))
                        {
                            RawVoteCount.Remove(voter);
                        }

                        //Add the vote to the votecount
                        RawVoteCount.Add(voter, votee);

                        logger.LogVote(post.PostNumber, voter, votee);
                    }
                    else
                    {
                        logger.LogInvalidTarget(post.PostNumber, voter, votee);
                    }
                }
                else
                {
                    logger.LogInvalidVoter(post.PostNumber, voter);
                }
            }
        }

        private bool IsVoteeValid(string vote, out string votee)
        {
            foreach (Player p in PlayerList)
            {
                //check to see if the player being voted for is on the playerlist
                if (String.Compare(vote, p.MainName, true) == 0)
                {
                    votee = p.MainName;
                    return true;
                }
                else
                {
                    foreach (string nickname in p.NicknameList)
                    {
                        //or if it has a nickname in the list
                        if (String.Compare(vote, nickname, true) == 0)
                        {
                            votee = p.MainName;
                            return true;
                        }
                    }
                }
            }

            //Not voting for a valid player, so check for "no lynch" votes
            if ((new[] { "No Lynch", "NoLynch" }).Contains(vote, StringComparer.OrdinalIgnoreCase))
            {
                votee = "No Lynch";
                return true;
            }

            //Still no valid vote, so return false
            votee = vote;
            return false;
        }

        private bool IsVoterValid(string voter)
        {
            //A votee is only valid if they are on the playerlist
            foreach (Player p in PlayerList)
            {
                if(String.Compare(voter, p.MainName, false) == 0) //Case insensitive because it needs to exactly match MTGS username
                {
                    return true;
                }
            }
            return false;
        }


        //Create a votecount where key is votee and value is list of players voting for that player
        public Dictionary<string, List<string>> CreateVotecount()
        {
            var voteCount = new Dictionary<string, List<string>>();
            foreach(DictionaryEntry kvp in RawVoteCount)
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
            //Sort the vote count by number of votes each votee has received
            voteCount = voteCount.OrderByDescending(x => x.Value.Count).ToDictionary(pair => pair.Key, pair => pair.Value);

            //List Not Voting at the bottom of the votecount
            List<string> notVoting = new List<string>();

            foreach(Player player in PlayerList)
            {
                if (!RawVoteCount.Contains(player.MainName))
                {
                    notVoting.Add(player.MainName);
                }
            }
            voteCount.Add("Not Voting", notVoting);

            return voteCount;
        }
    }
}
