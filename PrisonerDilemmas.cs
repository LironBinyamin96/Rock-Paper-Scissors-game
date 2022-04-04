using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class PrisonerDilemmas : Game
    {
        public PrisonerDilemmas(Player p1, Player p2) : base(p1, p2, "Prisoner's Dilemma")
        {
           
        }
        protected override void InitActions()
        {
            actions = new Action[] { new Action("Silence"), new Action("Blame")};
        }
        protected override void rewardPlayers(Action a1, Action a2)
        {
            if (a1.getName().Equals("Blame"))
            {
                if (a2.getName().Equals("Blame"))
                {
                    getFirstPlayer().UpdateScore(-5);
                    getSecondPlayer().UpdateScore(-5);
                    Console.WriteLine("-5, -5");
                }
                else
                {
                    getSecondPlayer().UpdateScore(-15);
                    Console.WriteLine("0, -15");
                }
            } 

            else 
            {
                if (a2.getName().Equals("Blame"))
                {
                    getFirstPlayer().UpdateScore(-15);
                    Console.WriteLine("-15, 0");
                }
                else
                {
                    getFirstPlayer().UpdateScore(-1);
                    getSecondPlayer().UpdateScore(-1);
                    Console.WriteLine("-1, -1");
                }
            }

        }
    }
}
