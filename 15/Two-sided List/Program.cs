using System;


namespace Two_sided_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.AddFirst(-2);
            list.AddFirst(-3);
            list.Add(0);
            list.Add(1);
            list.AddFirst(-4);
            list.Add(2); //-4 -3 -2 0 1 2

            list.DeleteLast();
            int[] array = list.ToArray();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(list.Contains(0)); //True
            Console.WriteLine(list.Contains(7)); //False

            Console.ReadKey();
        }
    }
}