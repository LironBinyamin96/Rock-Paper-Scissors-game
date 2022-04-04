using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class Program
    {
        static void Main(string[] args)
        {
            Player p1 = new RandomPlayer("p1");
            Player p2 = new ConsecutivePlayer("p2");
            Game g1 = new RockPaperScissors(p1, p2);
            g1.Play(5);
            Console.ReadKey();
        }
    }
}
