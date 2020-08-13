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
        public string choice2 = "";
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
        public void HumanChoice()
        {
            Human human = new Human();
            choice = human.Choose();
        }
        public void CPUChoice()
        {
            Computer computer = new Computer();
            choice2 = computer.CPUChoose();
        }
    }
}
