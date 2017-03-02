using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Player
    {
        public int numberOfVotes { get; set; }                                                            //number of votes player has

        public List<string> nicknameList { get; set; }                                                    //all names player goes by. 

        public string mainName { get; set; }                                                               //forum name. 

        public DateTime lastPost { get; set; }                                                             //the last day&time this player posted.            

        public int numTimesVoted { get; set; }                                                              //tracks the number of votes a player currently has active  

        public List<Player> whoIAmVotingFor { get; set; }                                                   //List whose max size will be numberOfVotes, will use this to track multivotes

        public Player(string mainName, int numberOfVotes, List<string> nicknames)
        {
            this.numberOfVotes = numberOfVotes;
            this.mainName = mainName;
            lastPost = new DateTime();
            nicknameList = nicknames;
        }

        //assumes no multivoters. 
        public Player(string mainName, List<string> nicknames)
            : this(mainName, 1, nicknames)
        {
            lastPost = new DateTime();
        }

        //also assumes no multivoters
        public Player(string mainName)
        : this(mainName, 1, new List<string>())
        {
            lastPost = new DateTime();
        }
    }
}
