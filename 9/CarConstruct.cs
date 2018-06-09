namespace HW8_2
{
    static class CarConstruct
    {
       public static Car Construct(Engine engine, Color color, Transmission transmission)
        {
            return new Car(engine, color, transmission);
        }

        public static Car Reconstruct(Car car,Engine engine)
        {
            car.Engine = engine;
            return car;
        }
    }
}
