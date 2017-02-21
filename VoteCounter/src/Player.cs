using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Player
    {
        public int numberOfVotes { get; set; }                                               //number of votes player has
        public List<string> nicknameList { get; set; }                                       //all names player goes by. 
        public string mainName { get; set; }                                                 //forum name. 
        public DateTime lastPost { get; set; }                                               //the last day&time this player posted. 

      public  Player()
        {
            numberOfVotes = 1;
            mainName = ("Foobar");
            lastPost = new DateTime();
        }

        public Player(string mainName, int numberOfVotes )
        {
            this.numberOfVotes = numberOfVotes;
            this.mainName = mainName;
            lastPost = new DateTime();
        }

        //assumes no multivoters. 
        public Player(string mainName)
        {
            Player p = new Player(mainName, 1);

        }
    }
}
