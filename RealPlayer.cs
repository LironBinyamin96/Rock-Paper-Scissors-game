using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class RealPlayer : Player
    {
        public RealPlayer(string name) : base(name)
        {

        }
        public override Action SelectAction(Action[] actions)
        {
            Console.WriteLine("choose action:");
            for(int i = 0; i < actions.Length; i++)
            {
                Console.WriteLine($"for {actions[i].getName()} enter {i+1}");
            }
            int n = int.Parse(Console.ReadLine());
            return actions[n - 1];
        }
    }
}
