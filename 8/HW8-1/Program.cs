using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Copying reference type

                StringBuilder s1 = new StringBuilder("abc");
                StringBuilder s2 = s1;
                s2.Replace("abc", "bca");
                Console.WriteLine(s1);//bca
                Console.WriteLine(s2);//bca

            #endregion

            Console.WriteLine();

            #region Copying value type

            string st1 = "abc";
            string st2 = st1;
            st2 = "bca";
            Console.WriteLine(st1);//abc
            Console.WriteLine(st2);//bca

            #endregion

            User us1 = new User(1,"1", true);
            User us2;

            us1.ShallowClone(out us2);
            Console.WriteLine(ReferenceEquals(us1, us2));//true

            us1.DeepClone(out us2);
            Console.WriteLine(ReferenceEquals(us1,us2));//false
            Console.ReadKey();
        }
    }
}
