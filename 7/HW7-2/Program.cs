using System;

namespace HW7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Human a = new Human(2012, "Alex","",6);
            Human b = new Human(2012, "Alex", ""); 
            Console.WriteLine(Human.Equals(a,b)); //True, because string behaves as ValueType

            Human a1= new Human(a);
            Console.WriteLine(Human.Equals(a1,a));//True

            Human c = new Human(2012,"John","", 6);
            Console.WriteLine(Human.Equals(a,c)); //False

            Console.ReadKey();
        }
    }
}
