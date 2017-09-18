using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHockeyPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            HockeyPlayer myHockeyPlayer = new HockeyPlayer("Gretzky", 99, 1000);

            HockeyPlayer.Display(myHockeyPlayer);

            Console.ReadLine();
        }
    }
}
