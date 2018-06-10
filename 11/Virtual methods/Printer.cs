using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_methods
{
    public class Printer
    {
        public virtual void Print(string message)
        {
            Console.WriteLine("Printer prints: "+message);
        }
    }
}
