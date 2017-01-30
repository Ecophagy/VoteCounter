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
        public string mainName { get; set; }                                                 //the name that most people would call this person. May remove, using first name in nicknameList. 
        public DateTime lastPost { get; set; }                                               //the last day&time this player posted.
        public int hoursSinceLastPost { get; set; }                                          //calender hours since last post.
        public int playerNumber { get; set; }                                                //number on vote count. Will be used as a key.

        static public int totalPlayerCount = 0;                                              //debug variable. knows how many times the player class has been created. 

      public  Player()
        {
            numberOfVotes = 1;
            mainName = ("Foobar");
            lastPost = new DateTime(1900, 1, 1, 1, 1, 1);
            hoursSinceLastPost = 0;

            totalPlayerCount++;
        }

        public Player(int a_playerNumber, string a_mainName, int a_numberOfVotes )
        {
            numberOfVotes = a_numberOfVotes;
            mainName = a_mainName;
            lastPost = new DateTime(1900, 1, 1, 1, 1, 1);
            hoursSinceLastPost = 0;
            playerNumber = a_playerNumber;

            totalPlayerCount++;
        }

        //assumes no multivoters. 
        public Player(int a_playerNumber, string a_mainName)
        {
            numberOfVotes = 1;
            mainName = a_mainName;
            lastPost = new DateTime(1900, 1, 1, 1, 1, 1);
            hoursSinceLastPost = 0;
            playerNumber = a_playerNumber;

            totalPlayerCount++;
           
        }

        ~Player()
        {
            if(totalPlayerCount < 0)
                totalPlayerCount--;

            nicknameList.Clear();
        }

    }
}
