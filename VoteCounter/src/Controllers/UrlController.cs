using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter.src.Controllers
{
    class UrlController
    {
        public bool ValidateUrl(string url)
        {
            return (url.Contains("mtgsalvation"));
        }
    }
}
