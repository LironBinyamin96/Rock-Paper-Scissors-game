using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class RandomPlayer : Player
    {
        private Random rnd = new Random();
        public RandomPlayer(String name) : base(name)
        {

        }
        public override Action SelectAction(Action[] actions)
        {
            return actions[rnd.Next(actions.Length)];
        }
    }
}
