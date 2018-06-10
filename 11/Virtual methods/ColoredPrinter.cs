using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_methods
{
    public class ColoredPrinter:Printer
    {
        public override void Print(string message="")
        {
            Console.WriteLine("ColoredPrinter prints: " + message);
        }
        public void Print(string text, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Colorful printing: "+text);
            Console.ResetColor();
        }
        
        
    }
}
