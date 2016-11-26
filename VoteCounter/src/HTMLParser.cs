using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Net;
using System.Globalization;

namespace VoteCounter
{
    class HtmlParser
    {
        private HtmlDocument doc;

        public HtmlParser(string url)
        {
            doc = new HtmlDocument();
            string html;
            using (var client = new WebClient())
            {
                html = client.DownloadString(url);
            }
            doc.LoadHtml(html);
        }

        public List<HtmlNode> getListofHtmlPosts()
        {
            HtmlNode commentList = doc.DocumentNode.SelectSingleNode("//ul[@id='comments']");
            return commentList.SelectNodes(".//li[@class='p-comments p-comments-b']").ToList();
        }

    }
}

