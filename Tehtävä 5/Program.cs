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
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a table that has five spaces for objects
            Student[] students = new Student[5];

            for (int i = 0; i != 5; i++)
            {
                // Creating an object to student table slot i
                students[i] = new Student();

                Console.WriteLine("Student slot : " + (i + 1));
                Console.Write("Please enter first name: ");
                students[i].Firstname = Console.ReadLine();
                Console.Write("Please enter last name: ");
                students[i].Lastname = Console.ReadLine();
                Console.Write("Please enter age: ");
                students[i].Age = int.Parse(Console.ReadLine());
            }

            int input = 0;

            do
            {
                //Menu
            Console.WriteLine("Menu");
            Console.WriteLine("1. Increase age");
            Console.WriteLine("2. Show all students");
            Console.WriteLine("3. Quit");

            input = int.Parse(Console.ReadLine());

                switch (input)
                {

                    case 1: // Increase age of a student
                        {

                            do
                            {
                                Console.WriteLine("Which student should get older 1-5?");
                                input = int.Parse(Console.ReadLine());
                                input--;
                            } while (input < 0 || input > 4);

                            //jumping to method ageup
                            students[input].ageup();

                            Console.WriteLine("Student {0} is now {1} years old.", students[input].Firstname, students[input].Age);
                            break;
                        }

                    case 2: //Accessing method printdata five times through for loop
                        {
                            for (int i = 0; i != 5; i++)
                            {
                                students[i].printdata();
                            }
                            break;
                        }
                    case 3: // Quit
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                }
            } while (input != 3);
        }
    }
}
