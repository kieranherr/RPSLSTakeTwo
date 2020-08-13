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
            //PlayerParent test = new PlayerParent();
            //test.Test();

            Human human = new Human();
            string test = human.Choose();
        }
    }
}
