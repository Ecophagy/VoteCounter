using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter.src.Controllers
{
    class VoteCountController
    {
        public VoteCountBuilder generateVoteCount(string url, int startingPostNumber, int endingPostNumber, List<Player> players)
        {
            var logger = new LogController();

            logger.ClearLogEntries();

            var postList = new PostListBuilder(url, startingPostNumber, endingPostNumber);

            //For each post, search the text for votes
            var voteCount = new VoteCountBuilder(players, logger);
            voteCount.FindVotes(postList.ListOfPosts);

            return voteCount;
        }

        public string FormatVoteCount(VoteCountBuilder voteCount)
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
