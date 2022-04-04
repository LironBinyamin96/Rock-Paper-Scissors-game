using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class RockPaperScissors : Game
    {
        
        public RockPaperScissors(Player p1, Player p2) : base(p1, p2, "Rock Paper Scissors")
        {
            
        }
        protected override void InitActions()
        {
            actions = new Action[] { new Action("Rock"), new Action("Paper"), new Action("Scissors") };
        }
        protected override void rewardPlayers(Action a1, Action a2)
        {
            if (!a1.Equals(a2))
            {
                if (a1.getName().Equals("Rock") && a2.getName().Equals("Scissors") ||
                    a1.getName().Equals("Paper") && a2.getName().Equals("Rock") ||
                    a1.getName().Equals("Scissors") && a2.getName().Equals("Paper"))
                {
                    getFirstPlayer().UpdateScore(1);
                    getSecondPlayer().UpdateScore(-1);
                    Console.WriteLine("1, -1");
                }
                else
                {
                    getFirstPlayer().UpdateScore(-11);
                    getSecondPlayer().UpdateScore(1);
                    Console.WriteLine("-1, 1");
                }
            }
            else
            {
                Console.WriteLine("0, 0");

            }
        }
    }
}
