using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Globalization;

namespace VoteCounter
{
    class Program
    {
        private static string URL = "http://www.mtgsalvation.com/forums/forum-games/mafia/762585-unreliable-cops-mafia-game-over-mafia-victory";

        static void Main(string[] args)
        {
            var parser = new HtmlParser(URL);
            var nodes = parser.getListofHtmlPosts();
      
            //Convert each HTML post construct to a post object and add them to a list
            List<Post> PostList = new List<Post>();
            foreach (HtmlNode node in nodes)
            {
                PostList.Add(new Post(node));
            }

            //For each post, search the text for votes
            var voteCount = new VoteCount();
            voteCount.FindVotes(PostList);

            //Print out the votecount!
            foreach (KeyValuePair<string, string> kvp in voteCount.voteCount)
            {
                Console.WriteLine("{0} is voting {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
