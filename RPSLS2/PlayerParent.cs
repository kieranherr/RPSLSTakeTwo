using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class PlayerParent
    {
        public List<string> moves = new List<string>();
        public string choice = "";
        public int playerOneScore = 0;
        public int playerTwoScore = 0;

        public PlayerParent()
        {
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
        }
        
        
    }
}
