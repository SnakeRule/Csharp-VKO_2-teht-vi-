using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Beertap beertap = new Beertap();

            int input;
            Console.WriteLine("Welcome to the beer pouring/drinking simulator!");
            do
            {
                Console.WriteLine("1. Pour small beer");
                Console.WriteLine("2. Pour medium beer");
                Console.WriteLine("3. Pour Large beer");
                Console.WriteLine("4. Check how drunk you are");
                Console.WriteLine("5. Check how much money you have spent");
                Console.WriteLine("6. Go home");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(input)
                {
                    case 1:
                        {
                            beertap.Pour_smallbeer();
                            break;
                        }

                    case 2:
                        {
                            beertap.Pour_mediumbeer();
                            break;
                        }
                    case 3:
                        {
                            beertap.Pour_largebeer();
                            break;
                        }
                    case 4:
                        {
                            beertap.How_drunk();
                            break;
                        }
                    case 5:
                        {
                            beertap.Money_spent();
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Loser");
                            break;
                        }
                }

            } while (input != 6);

            Console.ReadLine();
        }
    }
}
