using System;

namespace Datetime_and_Math_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //  DateTime Struct
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(21));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(150));
            Console.WriteLine(DateTime.Now.AddSeconds(36));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(4));

            //  Datetime Formatları
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));

            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //  Math Classı
            Console.WriteLine(Math.Abs(-15));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(45));
            Console.WriteLine(Math.Tan(60));

            Console.WriteLine(Math.Ceiling(1.9999999999999)); //    to 1    
            Console.WriteLine(Math.Floor(1.0000000000001)); //  to 2
            Console.WriteLine(Math.Round(7.2)); // to 7
            Console.WriteLine(Math.Round(7.8)); // to 8

            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Log(6));
            Console.WriteLine(Math.Exp(3));
            Console.WriteLine(Math.Log10(10));
            
        }
    }
}
