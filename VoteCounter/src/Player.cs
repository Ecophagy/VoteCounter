using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Player
    {
        public int numberOfVotes { get; set; }                                            //number of votes player has
      //  { get { return this.numberOfVotes; } set { this.numberOfVotes = value; } }                                               
        public List<string> nicknameList { get; set; }                                                    //all names player goes by. 
            // { get { return this.nicknameList; } set { this.nicknameList = value; } }                                    
        public string mainName { get; set; }                                                               //forum name. 
              //  { get {return this.mainName; } set {this.mainName = value; } }                                                
        public DateTime lastPost { get; set; }                                                             //the last day&time this player posted.
            //   { get {return this.lastPost; } set {this.lastPost = value; } }                                               

        public  Player()
        {
            numberOfVotes = 1;
            mainName = ("Foobar");
            lastPost = new DateTime();
        }

        public Player(Player p)
            {
            this.numberOfVotes = p.numberOfVotes;
            this.mainName = p.mainName;
            lastPost = p.lastPost;
            nicknameList = p.nicknameList;
        }

        public Player(string mainName, int numberOfVotes, List<string> nicknames)
        {
            this.numberOfVotes = numberOfVotes;
            this.mainName = mainName;
            lastPost = new DateTime();
            nicknameList = nicknames;
        }

        //assumes no multivoters. 
        public Player(string mainName, List<string> nicknames)
        {
            Player p = new Player(mainName, 1, nicknames);
        }
        
        //also assumes no multivoters
            public Player(string mainName)
        {
            Player p = new Player(mainName, 1, new List<string>());
        }
    }
}
