using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_ve_Math_Siniflari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);//haftanın gününü string olarak getiriyor.
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.AddDays(3));
            Console.WriteLine(DateTime.Now.AddSeconds(3));
            Console.WriteLine(DateTime.Now.AddMonths(3));
            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMilliseconds(10));
            //date-time format
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));//04
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(25));
            Console.WriteLine(Math.Cos(25));
            Console.WriteLine(Math.Tan(25));

            Console.WriteLine(Math.Ceiling(25.3));
            Console.WriteLine(Math.Round(25.3));//en yakına yuvarlar
            Console.WriteLine(Math.Floor(25.3));

            Console.WriteLine(Math.Max(25,3));
            Console.WriteLine(Math.Min(25,3));

            Console.WriteLine(Math.Pow(3,3));
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Log(25));
            Console.WriteLine(Math.Exp(3));// e üzeri üç verir.
            Console.WriteLine(Math.Log10(10));
        }
    }
}
