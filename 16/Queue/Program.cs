using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    

    class  MainClass
    {
        private static void Main(string[] args)
        {
            Queue<string> sQueue = new Queue<string>();
            sQueue.Enqueue("1");
            sQueue.Enqueue("2");
            sQueue.Enqueue("3");
            sQueue.Enqueue("4");


            Console.WriteLine(sQueue.Dequeue());
            sQueue.Dequeue();
            Console.WriteLine(sQueue.Peek()+" - Peek() works.");
            sQueue.Dequeue();
            //sQueue.Dequeue(); Error: NullReferenceException
            Console.WriteLine(
                sQueue.Current.Value);
            sQueue.Dequeue();
            Console.ReadKey();
        }
    }
}
