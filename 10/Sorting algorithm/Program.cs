using System;

namespace Sorting_algorithm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = {1, 2, 3, 4};
            SelectionSort(array);
            foreach (var item in array) Console.Write("{0} ", item);
            Console.ReadKey();
        }

        private static void SelectionSort(int[] array)
        {
            var max = array[0];
            var edge = 0;
            for (var i = 0; i < array.Length; i++)
            {
                var maxIndex = edge;
                max = array[edge];
                for (var j = edge; j < array.Length; j++)
                    if (array[j] > array[maxIndex])
                    {
                        maxIndex = j;
                        max = array[j];
                    }

                array[maxIndex] = array[edge];
                array[edge] = max;
                edge++;
            }
        }
    }
}