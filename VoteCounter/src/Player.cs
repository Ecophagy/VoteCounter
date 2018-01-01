using System.Collections.Generic;

namespace VoteCounter
{
    class Player
    {
        public List<string> NicknameList { get; set; }                                                    //all names player goes by. 

        public string MainName { get; set; }                                                              //forum name. 

        public Player()
        {
            MainName = "";
            NicknameList = new List<string>();
        }

        public Player(string mainName, List<string> nicknames)
        {
            this.MainName = mainName;
            this.NicknameList = nicknames;
        }

    }
}
