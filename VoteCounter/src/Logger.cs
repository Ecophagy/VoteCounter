using System.ComponentModel;

namespace VoteCounter
{
    class Logger
    {
        public BindingList<string> LogEntries { get; set; }

        public Logger()
        {
            LogEntries = new BindingList<string>();
        }

        public void ClearLogEntries()
        {
            LogEntries.Clear();
        }

        public void LogVote(uint postNumber, string voter, string votee)
        {
            LogEntries.Add("#" + postNumber + ": " + voter + " voted for " + votee);
        }

        public void LogInvalidTarget(uint postNumber, string voter, string votee)
        {
            LogEntries.Add("#" + postNumber + ": " + voter + " voted an invalid name \"" + votee +"\" - Vote Ignored");
        } 

        public void LogInvalidVoter(uint postNumber, string voter)
        {
            LogEntries.Add("#" + postNumber + ": " + voter + " is not on the player list - Vote Ignored");
        }


    }
}
