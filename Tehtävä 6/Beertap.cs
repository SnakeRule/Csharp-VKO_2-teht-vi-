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
    class Beertap
    {
        //These public properties are for counting how many beers you've had
        public int Smallbeers { get; set; }
        public int Mediumbeers { get; set; }
        public int Largebeers { get; set; }
        public bool tap_onoff { get; set; }


        // Method for using the tap. This only really has cosmetic uses
        public void Usetap()
        {
            if (tap_onoff == false)
            {
                Console.WriteLine("Press any button to open tap");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Pouring...");
                System.Threading.Thread.Sleep(2000); // System waits for 2 seconds before continuing
                tap_onoff = true;
            }
            else
            {
                Console.WriteLine("Press any button to close tap");
                Console.ReadKey();
                Console.Clear();
                tap_onoff = false;
            }
        }

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

    }
}
