using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            bool ans = false;
            game.SecondPlayer();
            while(ans == false)
            {
                game.CompareGestures();
                ans = game.DetermineWinner();
            }
        }
    }
}
