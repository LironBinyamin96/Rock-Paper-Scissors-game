using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    abstract class Game
    {
        private Player p1, p2;
        private string name; //game name
        protected Action[] actions; // the set of actions
        public Game(Player p1, Player p2, string name)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.name = name;
            InitActions();
        }
        protected abstract void InitActions();
        public void Play(int turnCount)
        {
            if(p1 is RealPlayer && p2 is ConsecutivePlayer || p1 is ConsecutivePlayer && p2 is RealPlayer)
            {
                Console.WriteLine("consecutive player cant play with real player");
            }
            else
            {
                    for (int i = 0; i < turnCount; i++)
                    {
                        playSingleTurn();
                    }
                    Console.WriteLine($"Game over, the winner is {GetWinner().GetName()}");
            }
        }
        private void playSingleTurn()
        {
            Action a1 = p1.SelectAction(actions);
            Action a2 = p2.SelectAction(actions);
            rewardPlayers(a1, a2);
            Console.WriteLine($"{p1.GetName()} : {a1.getName()} , {p2.GetName()} : {a2.getName()}");
        }
        // There is no real scoring strategy in a general
        // game
        protected abstract void rewardPlayers(Action a1, Action a2);
        public Player GetWinner()
        {

            return p1.IsWinner(p2) ? p1 : p2;
        }
        protected Player getFirstPlayer()
        {
            return this.p1;
        }
        protected Player getSecondPlayer()
        {
            return this.p2;
        }
    }
}
