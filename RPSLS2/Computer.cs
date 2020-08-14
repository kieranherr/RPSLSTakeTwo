using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS2
{
    class Computer : PlayerParent
    {
        private Random rnd = new Random();
        string choice;
        public override void ChooseGesture()
        {
            int num = rnd.Next(5);
            choice = moves[num];
        }
    }
}
