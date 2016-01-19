using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Beertap
    {
        public int Smallbeers;
        public int Mediumbeers;
        public int Largebeers;
        public int Small_moneyspent;
        public int Medium_moneyspent;
        public int Large_moneyspent;

        public void Pour_smallbeer()
        {
            Console.WriteLine("You pour a tasty small beer");
            Smallbeers++;
            Small_moneyspent = Small_moneyspent + 2;
        }

        public void Pour_mediumbeer()
        {
            Console.WriteLine("You pour an excellent medium beer");
            Mediumbeers++;
            Medium_moneyspent = Medium_moneyspent + 3;
        }

        public void Pour_largebeer()
        {
            Console.WriteLine("You pour an amazing large beer");
            Largebeers++;
            Large_moneyspent = Large_moneyspent + 5;
        }

        public void How_drunk()
        {
            Console.WriteLine("You have {0} promilles of alcohol in your blood." ,(Smallbeers * 0.1 + Mediumbeers * 0.3 + Largebeers * 0.5));
        }

        public void Money_spent()
        {
            Console.WriteLine( "You have spent {0} euros." ,Small_moneyspent + Medium_moneyspent + Large_moneyspent);
        }
    }
}
