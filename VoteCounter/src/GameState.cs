using System.Collections.Generic;

namespace VoteCounter
{
    class GameState
    {
        public string GameLink { get; set; }
        public int StartPost { get; set; }
        public int EndPost { get; set; }
        public List<Player> PlayerList { get; set; }
    }
}
