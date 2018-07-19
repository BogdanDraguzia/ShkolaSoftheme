using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("1");
            Console.WriteLine(stack.Peek());
            stack.Push("2");
            Console.WriteLine(stack.Peek());
            stack.Push("3");
            Console.WriteLine(stack.Peek());
            stack.Push("4");
            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());


            Console.ReadKey();
        }
    }
}
