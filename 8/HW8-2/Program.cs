namespace HW8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Engine(),new Color(), new Transmission());
            Car car2 = CarConstruct.Construct(new Engine(), new Color(), new Transmission());
            Car car3 = CarConstruct.Reconstruct(car2, new Engine()); 
             
            
            //no output, it just works (IMHO)
           
        }
    }
}
