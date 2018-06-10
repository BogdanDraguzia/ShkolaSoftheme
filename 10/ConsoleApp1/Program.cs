using System;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int?[] array = new int?[1001];

        private static void Main(string[] args)
        {
            Initialize();
            var distinct = GetDistinct();
            Console.WriteLine(distinct.ToString());

            Console.ReadKey();
        }

        private static int? GetDistinct()
        {
            int? distinct = null;
            for (var i = 0; i < 1001; i++)
            {
                var tmp = array[i]; //temporarily remove current item and then puts it back
                array[i] = null;
                if (!array.Contains(tmp))
                {
                    distinct = tmp;
                    break;
                }

                array[i] = tmp; //returning back to array
            }

            return distinct;
        }

        private static void Initialize()
        {
            for (var i = 0; i < 500; i++)
            {
                array[i] = i;
                array[i + 500] = i;
                array[1000] = 1000;
            }
        }
    }
}