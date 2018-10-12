using HtmlAgilityPack;
using System;
using System.Globalization;
using System.Linq;

namespace VoteCounter
{
    class Post
    {
        public string Poster { get; set; }
        public uint PostNumber { get; set; }
        public DateTime DateTimePosted { get; set; }
        public string Text { get; set; }

        public Post(HtmlNode node)
        {
            this.Poster = ExtractUserName(node);
            this.PostNumber = ExtractPostNumber(node);
            this.DateTimePosted = ExtractDateTimePosted(node);
            this.Text = ExtractPostContent(node);
        }

        private uint ExtractPostNumber(HtmlNode node)
        {
            string postNo = node.SelectSingleNode(".//a[@class='j-comment-link']").InnerText;
            return UInt32.Parse(postNo.Remove(0, 1)); //Remove the prefixing '#'
        }

        private DateTime ExtractDateTimePosted(HtmlNode node)
        {
            HtmlNode nd = node.SelectSingleNode(".//span[@itemprop='dateCreated']");
            string dt = node.SelectSingleNode(".//span[@itemprop='dateCreated']").GetAttributeValue("datetime", "");
            return DateTime.ParseExact(dt, "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
        }

        private string ExtractUserName(HtmlNode node)
        {
            return node.SelectSingleNode(".//span[@itemprop='name']").InnerText;
        }

        private string ExtractPostContent(HtmlNode node)
        {
            try
            {
                var quotes = node.SelectNodes(".//blockquote[@class='source-quote']").ToList();

                foreach (HtmlNode quote in quotes)
                {
                    quote.Remove();
                }
            }
            catch(ArgumentNullException)
            {
                //Do nothing (there were no quotes found)
            }
  
            return node.SelectSingleNode(".//div[@class='j-comment-body-container p-comment-body forum-post-body-content']").InnerHtml;
        }
    }
}

