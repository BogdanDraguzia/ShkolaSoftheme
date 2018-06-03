using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7_1
{
    class Car
    {
        public string Model { get; }
        public int Year { get;}
        public string Color { get; set; }

        public Car(string model, string color, int year)
        {
            Model = model;
            Color = color;
            Year = year;
        }
    }

    static class TuningAtelier
    {
        public static void TuneCar(Car car)
        {
            car.Color = "Red";
        }
    }

}
