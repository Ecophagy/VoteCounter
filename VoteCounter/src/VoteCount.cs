using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class VoteCount
    {
        public System.Collections.Concurrent.ConcurrentDictionary<string, string> voteCount { get; set; }

        public VoteCount()
        {
            voteCount = new System.Collections.Concurrent.ConcurrentDictionary<string, string>();
        }

        public void FindVotes(List<Post> PostList)
        {
            foreach (Post post in PostList)
            {
                string pattern = "<strong>vote:? (.+)</strong>";
                System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(
                                        post.text,
                                        pattern,
                                        System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    voteCount.AddOrUpdate(post.poster, match.Groups[1].Value, (k, v) => match.Groups[1].Value);
                }
            }
        }
    }
}
