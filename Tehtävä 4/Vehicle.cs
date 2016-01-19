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

namespace Tehtävä_4
{
    class Vehicle
    {
        // 

        public string Name;
        public int Speed;
        public int Tyres;

        //method for printing out vehicle data
        public void PrintData()
        {
            Console.WriteLine("Vehicle name : {0} ", Name);
            Console.WriteLine("Speed : {0}", Speed);
            Console.WriteLine("Tyres: {0}", Tyres);
        }

        public override string ToString()
        {
            return "Vehicle name : " + Name + ", Speed : " + Speed + ", Tyres : " + Tyres;
        }
    }
}
