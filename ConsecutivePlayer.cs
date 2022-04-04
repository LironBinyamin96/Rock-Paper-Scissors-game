using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class ConsecutivePlayer : Player
    {
        private int lastIdx;
        public ConsecutivePlayer(String name) : base(name)
        {
            lastIdx = 0;
        }
        public override Action SelectAction(Action[] actions)
        {
            
            return actions[lastIdx++ % actions.Length];
        }
    }
}
