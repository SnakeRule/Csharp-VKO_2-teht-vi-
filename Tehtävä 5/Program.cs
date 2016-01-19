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

            for (int i = 0; i != 5; i++)
            {
                Console.WriteLine("Student slot : " + (i + 1));
                Console.WriteLine("First Name : {0}", students[i].Firstname);
                Console.WriteLine("Last Name : {0}", students[i].Lastname);
                Console.WriteLine("age : {0}", students[i].Age);
            }
        }
    }
}
