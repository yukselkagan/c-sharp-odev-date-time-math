using System;

namespace c_sharp_odev_date_time_math
{
    class Program
    {
        static void Main(string[] args)
        {


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



            Console.WriteLine(DateTime.Now.AddDays(5));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(5));
            Console.WriteLine(DateTime.Now.AddHours(5));
            Console.WriteLine(DateTime.Now.AddMinutes(5));
            Console.WriteLine(DateTime.Now.AddSeconds(5));
            Console.WriteLine(DateTime.Now.AddMilliseconds(5));



            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));


            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));


            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));


            Console.WriteLine(DateTime.Now.ToString("dd-MM-yyyy"));



            Console.WriteLine(Math.Abs(-20));
            Console.WriteLine(Math.Sin(30));
            Console.WriteLine(Math.Cos(30));
            Console.WriteLine(Math.Tan(30));



            Console.WriteLine(Math.Ceiling(20.4));
            Console.WriteLine(Math.Floor(20.8));
            Console.WriteLine(Math.Round(20.4));
            Console.WriteLine(Math.Round(20.5));


            Console.WriteLine(Math.Max(2,5));
            Console.WriteLine(Math.Min(2, 5));


            Console.WriteLine(Math.Pow(3, 4));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Log(9));
            Console.WriteLine(Math.Exp(9));
            Console.WriteLine(Math.Log10(10));



        }
    }
}
