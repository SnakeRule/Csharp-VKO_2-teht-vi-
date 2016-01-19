using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esim_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a Car instance
            Car car = new Car();
            car.Model = "Audi";
            car.Color = "Black";
            car.Engine = 2.0;
            car.FuzzyDices = false;
            car.Speed = 100;
            car.PrintData();

            Car nascar = new Car("Toyota");
            nascar.Speed = 200;
            nascar.Color = "Red";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.PrintData();
            nascar.Accelerate(50);
            nascar.PrintData();


            Console.ReadLine();
        }
    }
}
