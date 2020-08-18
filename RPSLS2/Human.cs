using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Human : PlayerParent
    {
        public override void ChooseGesture()
        {
            Console.WriteLine("What move would you like to throw?");
            Console.WriteLine("1: Rock");
            Console.WriteLine("2: Paper");
            Console.WriteLine("3: Scissors");
            Console.WriteLine("4: Lizard");
            Console.WriteLine("5: Spock");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    choice = moves[0];
                    break;
                case 2:
                    choice = moves[1];
                    break;
                case 3:
                    choice = moves[2];
                    break;
                case 4:
                    choice = moves[3];
                    break;
                case 5:
                    choice = moves[4];
                    break;
                default:
                    Console.WriteLine("Please choose one of the five options");
                    break;
            }
        }
    }
}
