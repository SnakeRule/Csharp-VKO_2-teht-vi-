using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    //This class is for the customer
    class Customer

    {

        //Method for checking how drunk you are, values come from class beertap
        public void How_drunk(int Smallbeers, int Mediumbeers, int Largebeers)
        {
            Console.WriteLine("You have {0} permille of alcohol in your blood.", (Smallbeers * 0.1 + Mediumbeers * 0.3 + Largebeers * 0.5));
        }

        //Method for checking how much money has been spent, values come from class beertap
        public void Money_spent(int Smallbeers, int Mediumbeers, int Largebeers)
        {
            Console.WriteLine("You have spent {0} euros.", Smallbeers * 2 + Mediumbeers * 3 + Largebeers * 5);
        }

    }
}
