using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä_1
{
    class Heater
    {
        public bool Is_On { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        // method prints heater data
        public void PrintData()
        {
            Console.WriteLine("Heater: ");
            Console.WriteLine("- Power {0},  Temperature : {1}, Humidity: {2} ", Is_On, Temperature, Humidity);

        }

        // method returns heater data
        public override string ToString()
        {
            return "Temperature : " + Temperature + ", Humidity : " + Humidity;
        }

    }
}
