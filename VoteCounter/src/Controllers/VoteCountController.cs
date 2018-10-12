using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter.src.Controllers
{
    class VoteCountController
    {
        public VoteCount generateVoteCount(string url, int startingPostNumber, int endingPostNumber, List<Player> players)
        {
            var logger = new LogController();

            logger.ClearLogEntries();

            var postList = new PostList(url, startingPostNumber, endingPostNumber);

            //For each post, search the text for votes
            var voteCount = new VoteCount(players, logger);
            voteCount.FindVotes(postList.ListOfPosts);

            return voteCount;
        }

        public string FormatVoteCount(VoteCount voteCount)
        {
            StringBuilder voteText = new StringBuilder();

            //Print out the votecount!
            foreach (KeyValuePair<string, List<string>> kvp in voteCount.CreateVotecount())
            {
                voteText.Append(kvp.Key + " - " + kvp.Value.Count + " (");

                foreach (string voter in kvp.Value)
                {
                    voteText.Append(voter);
                    if (kvp.Value.IndexOf(voter) != kvp.Value.Count - 1)
                    {
                        voteText.Append(", ");
                    }
                }
                voteText.AppendLine(")");
            }

            return voteText.ToString();

        }
    }
}
