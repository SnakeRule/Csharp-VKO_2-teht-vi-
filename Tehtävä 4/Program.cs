using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a new vehicle object
            Vehicle vehicle = new Vehicle();

            //assigning data to vehicle object
            vehicle.Name = "Audi";
            vehicle.Speed = 300;
            vehicle.Tyres = 4;

            vehicle.PrintData();

            Console.WriteLine("And using another printing method");

            Console.WriteLine(vehicle.ToString());


   
        }
    }
}
