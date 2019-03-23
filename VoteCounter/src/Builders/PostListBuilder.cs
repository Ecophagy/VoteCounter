using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using VoteCounter.src.Controllers;

namespace VoteCounter
{
    class PostListBuilder
    {
        public List<Post> ListOfPosts { get; }

        public PostListBuilder(String URL, int startingPostNumber, int endingPostNumber)
        {
            ListOfPosts = new List<Post>();
            int startingPage = (int)Math.Ceiling((decimal)startingPostNumber / 50);
            int endingPage = (int)Math.Ceiling((decimal)endingPostNumber / 50);
            for (int i = startingPage; i <= endingPage; i++)
            {
                var parser = new HtmlParser(URL + "?page=" + i);
                var nodes = parser.getListofHtmlPosts();

                var postBuilder = new PostBuilder();

                //Convert each HTML post construct to a post object and add them to a list
                foreach (HtmlNode node in nodes)
                {
                    Post post = postBuilder.BuildPost(node);
                    if (post.PostNumber >= startingPostNumber && post.PostNumber <= endingPostNumber)
                    {
                        ListOfPosts.Add(post);
                    }
                }
            }
        }
    }
}
