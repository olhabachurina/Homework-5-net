using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_net
{
   public class Journal
    {
        private int numberofpeople;
        public int NumberOfPeople
        { get { return numberofpeople; }
            set { numberofpeople = value; }
        }
        public override bool Equals(object obj)
        {
            if (obj is Journal)
            {
                Journal other = (Journal)obj;
                return this.NumberOfPeople == other.NumberOfPeople;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return NumberOfPeople.GetHashCode();
        }
    }
}

