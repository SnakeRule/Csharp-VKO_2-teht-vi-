using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esim_1
{
    class Car
    {
        // field members not included

        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }

        // Constructor
        public Car()
        {
            FuzzyDices = true;
        }

        // Parametric constructor
        public Car(string model)
        {
            Model = model;
        }

        // method displays car data
        public void PrintData()
        {
            Console.WriteLine("Car data:");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- FuzzyDices : " + FuzzyDices);
        }

        // method gives more speed

        public void Accelerate(int newSpeed)
        {
            Speed += newSpeed;
        }
    }
}
