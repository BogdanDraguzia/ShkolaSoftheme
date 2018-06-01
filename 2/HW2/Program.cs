using System;
using System.IO;


namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Press Enter after every number and also after math operator!" +
                              "\n--------------------------------------------------------------------------------------------");
            try
            {
                a = Double.Parse(Console.ReadLine());
                var sign = Console.ReadLine().Replace(" ", "");
                b = Double.Parse(Console.ReadLine());
                switch (sign)
                {
                    case "+":
                        Console.Write("{0:0.##}",(a + b)); // {0:00.00} вывел бы ровно два знака после запятой
                        break;
                    case "-":
                        Console.Write("{0:0.##}",a - b);
                        break;
                    case "*":
                        Console.Write("{0:0.##}",a * b);
                        break;
                    case "/":
                        Console.Write("{0:0.##}", a / b);
                        break;
                    default:
                        throw new IOException("Bad mathematical operator");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            Console.ReadKey();


        }

       
    }
}
