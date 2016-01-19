/*
* Copyright (C) Jere-Joonas Valtanen
*
* This file is part of JAMK object oriented programming course
*
* Created: 19.1.2016
*Author: Jere-Joonas Valtanen
*/

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
            //Creating object beertap
            Beertap beertap = new Beertap();

            int input;
            Console.WriteLine("Welcome to the beer pouring/drinking simulator!");
            Console.WriteLine();
            do
            {
                // Menu
                Console.WriteLine("1. Pour small beer");
                Console.WriteLine("2. Pour medium beer");
                Console.WriteLine("3. Pour Large beer");
                Console.WriteLine("4. Check how drunk you are");
                Console.WriteLine("5. Check how much money you have spent");
                Console.WriteLine("6. Go home");
                input = int.Parse(Console.ReadLine());
                Console.Clear();

                // Switch case based on menu selection
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
                    default: break;
                }

            } while (input != 6); // Loop breaks if input is 6

            Console.ReadLine();
        }
    }
}
