using System;

namespace SmartArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var array = new ArrayWrapper();
            array.Array = new[] {1, 2, 3, 4};
            Console.WriteLine(array);

            array.Add(5); //Push
            Console.WriteLine(array);

            array.Add(123, array.Length);
            array.Add(456, 3); //Insert at certain position
            Console.WriteLine(array);

            Console.WriteLine(array.Contains(3)); //True
            Console.WriteLine(array.Contains(6)); //False

            Console.WriteLine(array.GetByIndex(2)); //3
            Console.ReadKey();
        }
    }
}