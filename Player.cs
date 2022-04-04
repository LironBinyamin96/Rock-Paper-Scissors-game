using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    abstract class Player
    {
        private string name;
        private int score;
        public Player(string name)
        {
            this.name = name;
            this.score = 0;
        }
        public  abstract Action SelectAction(Action[]actions);
        public bool IsWinner(Player p)
        {
            return score > p.score;
            
        }
        public void UpdateScore(int score)
        {
            this.score += score;
        }
        public int GetScore()
        {
            return this.score;
        }
        public string GetName()
        {
            return this.name;
        }
    }
}
