using System;

namespace HW8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(Engine.Toyota,Color.Blue,Transmission.Tr3);
            Car car2 = CarConstruct.Construct(new Engine(), new Color(), new Transmission());
            Car car3 = CarConstruct.Reconstruct(car2, new Engine());

            Car car4 = car;
            car4 = CarConstruct.Reconstruct(car, Engine.Honda);
            Console.WriteLine(car.Engine==car4.Engine); //false


           

        }
    }
}
