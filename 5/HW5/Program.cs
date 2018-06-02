using System;

namespace HW5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            DrawSquare(8);
            DrawRomb(9);
            DrawTriangle(10);
            Console.ReadKey();
        }

        private static void DrawTriangle(int dimension)
        {
            for (var i = 1; i <= dimension; i++)
            {
                for (var j = 1; j <= i; j++) Console.Write("* ");

                Console.WriteLine();
            }
        }

        private static void DrawSquare(int dimension)
        {
            for (var i = 0; i < dimension; i++)
            {
                for (var j = 0; j < dimension; j++) Console.Write("# ");

                Console.WriteLine();
            }
        }

        private static void DrawRomb(int dimension)
        {
            var left = dimension - 1;
            var right = dimension + 1;
            for (var i = 1; i <= dimension; i++)
            {
                for (var j = 1; j <= dimension * 2 - 1; j++)
                    if ((j <= left) | (j >= right))
                        Console.Write("  ");
                    else
                        Console.Write("* ");

                Console.WriteLine();
                left--;
                right++;
            }

            left = 1;
            right = dimension * 2 - 1;
            for (var i = 1; i <= dimension; i++)
            {
                for (var j = 1; j <= dimension * 2 - 1; j++)
                    if ((j <= left) | (j >= right))
                        Console.Write("  ");
                    else
                        Console.Write("* ");

                Console.WriteLine();
                left++;
                right--;
            }
        }
    }
}
