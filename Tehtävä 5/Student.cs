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

namespace Tehtävä_5
{
    class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }


        //Method for aging up a student
        public void ageup()
        {
            Age++;
        }

        //Method for printing out the data of all students
        public void printdata()
        {
                Console.WriteLine("First Name : {0}", Firstname);
                Console.WriteLine("Last Name : {0}", Lastname);
                Console.WriteLine("age : {0}", Age);
            Console.WriteLine();
        }

    }
}
