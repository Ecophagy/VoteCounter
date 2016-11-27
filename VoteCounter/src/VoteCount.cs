using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class VoteCount
    {
        public System.Collections.Specialized.OrderedDictionary voteCount { get; set; }

        public VoteCount()
        {
            voteCount = new System.Collections.Specialized.OrderedDictionary();
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
                    //Is the poster already voting? If they are, remove their vote
                    if(voteCount.Contains(post.poster))
                    {
                        voteCount.Remove(post.poster);
                    }
                    voteCount.Add(post.poster, match.Groups[1].Value);
                }
            }
        }
    }
}
