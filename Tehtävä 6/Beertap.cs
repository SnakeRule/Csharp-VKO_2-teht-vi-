using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Beertap
    {
        //These public properties are for counting how many beers you've had
        public int Smallbeers { get; set; }
        public int Mediumbeers { get; set; }
        public int Largebeers { get; set; }

        //Method for pouring small beer
        public void Pour_smallbeer()
        {
            Console.WriteLine("You pour a tasty small beer");
            Smallbeers++;
        }

        //Method for pouring medium beer
        public void Pour_mediumbeer()
        {
            Console.WriteLine("You pour an excellent medium beer");
            Mediumbeers++;
        }

        //Method for pouring large beer
        public void Pour_largebeer()
        {
            Console.WriteLine("You pour an amazing large beer");
            Largebeers++;
        }

        //Method for checking how drunk you are
        public void How_drunk()
        {
            Console.WriteLine("You have {0} ‰ of alcohol in your blood.", (Smallbeers * 0.1 + Mediumbeers * 0.3 + Largebeers * 0.5));
        }

        //Method for checking how much money has been spent
        public void Money_spent()
        {
            Console.WriteLine( "You have spent {0} euros." ,Smallbeers * 2 + Mediumbeers * 3 + Largebeers * 5);
        }
    }
}
