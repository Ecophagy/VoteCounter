using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Globalization;
using System.Collections;

namespace VoteCounter
{
    class Program
    {
        private static string URL = "http://www.mtgsalvation.com/forums/forum-games/mafia/762585-unreliable-cops-mafia-game-over-mafia-victory";

        static void Main(string[] args)
        {
            int startingPostNumber = 200;
            int endingPostNumber = 238;

            PostList postList = new PostList(URL, startingPostNumber, endingPostNumber);

            //For each post, search the text for votes
            var voteCount = new VoteCount();
            voteCount.FindVotes(postList.ListOfPosts);

            //Print out the votecount!
            foreach (KeyValuePair<string, List<string>> kvp in voteCount.createVotecount())
            {
                Console.Write("{0} - {1} (", kvp.Key, kvp.Value.Count);
                foreach(string voter in kvp.Value)
                {
                    Console.Write("{0}", voter);
                    if(kvp.Value.IndexOf(voter) != kvp.Value.Count -1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine(")");
            }
        }
    }
}
