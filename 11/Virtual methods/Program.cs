using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_methods
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("");

            ColoredPrinter coloredPrinter = new ColoredPrinter();
            coloredPrinter.Print();
            ((Printer)coloredPrinter).Print("Overriding works");
            coloredPrinter.Print("method with different signature ", ConsoleColor.DarkCyan);

            PhotoPrinter photoPrinter = new PhotoPrinter();
            photoPrinter.Print();
            ((Printer)photoPrinter).Print("Overriding works");
            photoPrinter.Print(Photo.Second);
            Console.ReadKey();

        }
    }
}
