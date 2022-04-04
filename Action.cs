using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Game_
{
    class Action
    {
        private string name;
        public Action(string n)
        {
            this.name = n;
        }
        public String getName()
        {
            return this.name;
        }
        public bool Equals(object other)
        {
            if (other == null || this.GetType() != other.GetType())
                return false;
            Action obj = (Action)other;
            return this.name == obj.name;
        }
    }
}
