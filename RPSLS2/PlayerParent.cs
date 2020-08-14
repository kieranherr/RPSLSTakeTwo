using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    abstract class PlayerParent
    {
        public List<string> moves = new List<string>();
        public string choice = "";
        public int score = 0;
        public PlayerParent()
        {
            score = 0;
            moves.Add("Rock");
            moves.Add("Paper");
            moves.Add("Scissors");
            moves.Add("Lizard");
            moves.Add("Spock");
        }
        public abstract void ChooseGesture();
    }
}
