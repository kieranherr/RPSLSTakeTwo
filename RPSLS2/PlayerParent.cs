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
        public bool humanOrCPU = true; //true = human false = cpu

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
        public bool PlayerTypeChoice()
        {
            Console.WriteLine("Would you like to play against another human or against a computer?");
            string ans = Console.ReadLine();
            if(ans == "human" || ans == "Human")
            {
                humanOrCPU = true;
            }
            else if (ans == "CPU" || ans == "cpu" || ans == "Cpu")
            {
                humanOrCPU = false;
            }
            return humanOrCPU;
        }
    }
}
