using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Game
    {
        public PlayerParent player1;
        public PlayerParent player2;
        public Game()
        {

        }
       public void SecondPlayer()
        {
            Console.WriteLine("Would you like to play against another human or a CPU?");
            string ans = Console.ReadLine();
            switch (ans)
            {
                case "Human":
                    player2 = new Human();
                    break;
                case "CPU":
                    player2 = new Computer();
                    break;
                default:
                    Console.WriteLine("Please enter either Human or CPU");
                    break;
            }
        }
    }
}
