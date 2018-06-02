using System;
using System.Globalization;
using System.Text;

namespace HW4_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input date in dd/mm/yyyy format:");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            s.Replace(" ", "");
            string format = "dd/MM/yyyy";
            DateTime d = DateTime.ParseExact(s.ToString(), format,CultureInfo.InvariantCulture);
            //Console.WriteLine(d);
            DateTime d1 =  new DateTime(d.Year,1,21);
            DateTime d2 =  new DateTime(d.Year,2,22);
            DateTime d3 =  new DateTime(d.Year,3,21);
            DateTime d4 =  new DateTime(d.Year,4,22);
            DateTime d5 =  new DateTime(d.Year,5,22);
            DateTime d6 =  new DateTime(d.Year,6,23);
            DateTime d7 =  new DateTime(d.Year,7,23);
            DateTime d8 =  new DateTime(d.Year,8,23); 
            DateTime d9 =  new DateTime(d.Year,9,22);
            DateTime d10 = new DateTime(d.Year,10,24);
            DateTime d11 = new DateTime(d.Year,11,22);
            DateTime d12 = new DateTime(d.Year,12,22);

            StringBuilder sign = new StringBuilder();
            if (IsInInterval(d1, d2, d)) sign.Append("Aquaries");
            if (IsInInterval(d2, d3, d)) sign.Append("Picses");
            if (IsInInterval(d3, d4, d)) sign.Append("Aries");
            if (IsInInterval(d4, d5, d)) sign.Append("Taurus");
            if (IsInInterval(d5, d6, d)) sign.Append("Gemini");
            if (IsInInterval(d6, d7, d)) sign.Append("Cancer");
            if (IsInInterval(d7, d8, d)) sign.Append("Leo");
            if (IsInInterval(d8, d9, d)) sign.Append("Virgo");
            if (IsInInterval(d9, d10, d)) sign.Append("Libra");
            if (IsInInterval(d10, d11, d)) sign.Append("Scorpio");
            if (IsInInterval(d11, d12, d)) sign.Append("Sigittarius");
            if (IsInInterval(d12, d1, d)) sign.Append("Capricorn");
            Console.WriteLine("Your sign is "+sign);
            
            Console.ReadKey();
        }

        private static bool IsInInterval(DateTime left, DateTime right, DateTime d)
        {
            return (d >= left && d < right);
        }
    }
}
