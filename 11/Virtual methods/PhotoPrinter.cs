using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual_methods
{
    public class PhotoPrinter:Printer
    {
        public override void Print(string message="")
        {
            Console.WriteLine("PhotoPrinter prints:" + message);
        }

        public void Print(Photo photo)
        {
            Console.WriteLine(photo.ToString());
        }
        
    }
}
