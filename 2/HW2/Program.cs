using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            String num1, num2;
            num1 = "";num2 = "abc";
            num1 += num2;
            ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
            while ( keyInfo.Key!=ConsoleKey.Enter)
            {
                //keyInfo = new ConsoleKeyInfo();
                Console.WriteLine("Iteration");
            }
            Double.TryParse("123,45", out double result);

            Console.WriteLine(result*2);
            
            Console.ReadKey();
        }
    }
}
