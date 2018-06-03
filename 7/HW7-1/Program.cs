using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car("Toyota", "Yellow", 1996);
            TuningAtelier.TuneCar(newCar);
            Console.WriteLine(newCar.Color);
            Console.ReadKey();
        }
    }
}
