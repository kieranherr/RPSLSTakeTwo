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
            player1 = new Human();
        }
       public void SecondPlayer()
        {
            Console.WriteLine("Enter 1 to play against another Human.");
            Console.WriteLine("Enter 2 to play against a Computer");
            int ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 1:
                    player2 = new Human();
                    break;
                case 2:
                    player2 = new Computer();
                    break;
                default:
                    Console.WriteLine("Please enter either 1 for a Human or 2 for a Computer");
                    break;
            }
        }
        public void CompareGestures()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
            if(player1.choice == player2.choice)
            {
                Console.WriteLine("Its a tie!");
                Console.ReadLine();
            }
            else if(player1.choice == "Rock" && (player2.choice == "Scissors" || player2.choice == "Lizard"))
            {
                Console.WriteLine("Player one won this round!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Paper" && (player2.choice == "Rock" || player2.choice == "Spock"))
            {
                Console.WriteLine("Player one won this round!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Scissors" && (player2.choice == "Paper" || player2.choice == "Lizard"))
            {
                Console.WriteLine("Player one won this round!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Lizard" && (player2.choice == "Spock" || player2.choice == "Paper"))
            {
                Console.WriteLine("Player one won this round!");
                player1.score++;
                Console.ReadLine();
            }
            else if (player1.choice == "Spock" && (player2.choice == "Rock" || player2.choice == "Scissors"))
            {
                Console.WriteLine("Player one won this round!");
                player1.score++;
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Player two won this round!");
                player2.score++;
                Console.ReadLine();
            }
        }
        public bool DetermineWinner()
        {
            bool ans;
            if(player1.score == 2 && player2.score < 2)
            {
                Console.WriteLine("Player one won the game!!!");
                Console.ReadLine();
                ans = true;
            }
            else if(player2.score == 2 && player1.score < 2)
            {
                Console.WriteLine("Player two won the game!!!");
                Console.ReadLine();
                ans = true;
            }
            else
            {
                ans = false;
            }
            return ans;
        }
    }
}
