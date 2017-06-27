using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoteCounter
{
    class Player
    {
        public List<string> nicknameList { get; set; }                                                    //all names player goes by. 

        public string mainName { get; set; }                                                              //forum name. 

        public Player()
        {
            mainName = "";
            nicknameList = new List<string>();
        }

 
        public Player(string mainName, List<string> nicknames)
        {
            this.mainName = mainName;
            this.nicknameList = nicknames;
        }

    }
}
