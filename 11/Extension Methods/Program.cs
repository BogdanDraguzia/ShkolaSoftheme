using System;
using Virtual_methods;

namespace Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p1 = new Printer();
            string[] messages = new string[] {"one ", "two ", "three"};
            p1.Print(messages);

            ColoredPrinter c = new ColoredPrinter();
            ConsoleColor[] consoleColors = new ConsoleColor[]
                {ConsoleColor.Blue, ConsoleColor.Cyan, ConsoleColor.DarkRed};
            c.Print(messages, consoleColors);

            PhotoPrinter p = new PhotoPrinter();
            Photo[] photos = new Photo[] {Photo.First, Photo.Second, Photo.Third};
            p.Print(photos);
        }
    }

    static class ExtensionMethods
    {
        public static void Print(this Printer printer, string[] array)
        {
            foreach (var s in array)
            {
                printer.Print(s + " ");
            }
        }

        public static void Print(this ColoredPrinter coloredPrinter, string[] strings, ConsoleColor[] consoleColors)
        {
            if (consoleColors.Length != strings.Length)
            {
                throw new Exception("Not matching dimensions of messages and colors");
            }

            for (int i = 0; i < strings.Length; i++)
            {
                coloredPrinter.Print(strings[i], consoleColors[i]);
            }
        }

        public static void Print(this PhotoPrinter photoPrinter, Photo[] photos)
        {
            foreach (var photo in photos)
            {
                photoPrinter.Print(photo);
            }
        }
    }
}