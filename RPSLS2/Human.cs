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
            moves.ForEach(Console.WriteLine);
            Console.WriteLine("What move would you like to throw?");
            choice = Console.ReadLine();
        }
    }
}
