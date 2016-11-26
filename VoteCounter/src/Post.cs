using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Post
    {
        public string poster { get; set; }
        public uint postNumber { get; set; }
        public DateTime dateTimePosted { get; set; }
        public string text { get; set; }

        public Post(HtmlNode node)
        {
            this.poster = ExtractUserName(node);
            this.postNumber = ExtractPostNumber(node);
            this.dateTimePosted = ExtractDateTimePosted(node);
            this.text = ExtractPostContent(node);
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
            return DateTime.ParseExact(dt, "yyyy-dd-MMTHH:mm:ss", CultureInfo.InvariantCulture);
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

