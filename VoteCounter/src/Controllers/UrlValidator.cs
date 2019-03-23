namespace VoteCounter.src.Controllers
{
    class UrlValidator
    {
        public bool ValidateUrl(string url)
        {
            return (url.Contains("mtgsalvation"));
        }
    }
}
