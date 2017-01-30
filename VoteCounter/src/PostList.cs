using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    
    class PostList
    {
        public List<Post> ListOfPosts { get; }

        public PostList(String URL, int startingPostNumber, int endingPostNumber)
        {
            ListOfPosts = new List<Post>();
            int startingPage = (int)Math.Ceiling((decimal)startingPostNumber / 50); //rounds?
            int endingPage = (int)Math.Ceiling((decimal)endingPostNumber / 50);
            for (int i = startingPage; i <= endingPage; i++)
            {
                var parser = new HtmlParser(URL + "?page=" + i);
                var nodes = parser.getListofHtmlPosts();

                //Convert each HTML post construct to a post object and add them to a list

                foreach (HtmlNode node in nodes)
                {
                    Post post = new Post(node);
                    if (post.postNumber >= startingPostNumber && post.postNumber <= endingPostNumber)
                    {
                        ListOfPosts.Add(post);
                    }
                }
            }
        }

    }
}
