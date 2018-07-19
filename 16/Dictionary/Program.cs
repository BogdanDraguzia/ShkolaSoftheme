using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("a",1);
            dictionary.Add("b", 1);
            dictionary.Add("a", 5);//Not added
            dictionary.Remove("c");//Not removed
            dictionary.Remove("a"); //a removed

            Console.ReadKey();

        }
    }
}
