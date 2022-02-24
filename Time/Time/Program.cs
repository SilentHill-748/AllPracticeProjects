using System;
using System.Data;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace Time
{
    class Program
    {
        static void Main()
        {
            DateTime time = new DateTime();
            DateTime time2 = DateTime.Now;

            Console.WriteLine("time - " + time + " (Default)");
            Console.WriteLine("time2 - " + time2);

            Console.WriteLine();

            Console.WriteLine("Now - " + DateTime.Now);
            Console.WriteLine();

            Console.WriteLine("MinValue - " + DateTime.MinValue);
            Console.WriteLine();

            Console.WriteLine("DaysInMonth(2020, 10) - " + DateTime.DaysInMonth(2020, 10));         // 31
            Console.WriteLine();

            long longTime = time2.ToBinary();
            time = DateTime.FromBinary(longTime);
            Console.WriteLine("LongTime = " + longTime);
            Console.WriteLine("FromBinary(LongTime) - " + time);                                    // ?
            Console.WriteLine();

            Console.WriteLine("IsLeapYear(2020) - " + DateTime.IsLeapYear(2020));                   // True
            Console.WriteLine();

            Console.WriteLine("Parse(\"08.10.2020\") - " + DateTime.Parse("08.10.2020"));           // 08.10.2020 0:00:00
            Console.WriteLine();

            Console.WriteLine("MaxValue - " + DateTime.MaxValue);                                   // 31.12.9999 23:59:59
            Console.WriteLine();

            Console.WriteLine("UtcNow - " + DateTime.UtcNow);                                       // 08.10.2020 05:16:20
            Console.WriteLine();

            Console.WriteLine("Today - " + DateTime.Today);                                         // 08.10.2020
            Console.WriteLine();

            Console.WriteLine("SpecifyKind(time2, DateTimeKind.Utc) - " + 
                DateTime.SpecifyKind(time2, DateTimeKind.Utc));                                     // 08.10.2020 10:21:xx в формате UTC
            Console.WriteLine();

            Console.WriteLine("SpecifyKind(time2, DateTimeKind.Local) - " +
                DateTime.SpecifyKind(time2, DateTimeKind.Local));                                   // 08.10.2020 10:21:xx в формате Local
            Console.WriteLine();

            Console.WriteLine("SpecifyKind(time2, DateTimeKind.Unspecified) - " +
                DateTime.SpecifyKind(time2, DateTimeKind.Unspecified));                             // 08.10.2020 10:21:xx в формате Unspecified
            Console.WriteLine();

            long longTicks = time2.Ticks;
            Console.WriteLine(longTicks);

            int milliSec    = time2.Millisecond;
            int sec         = time2.Second;
            int min         = time2.Minute;
            int hour        = time2.Hour;
            int day         = time2.Day;
            int month       = time2.Month;
            int year        = time2.Year;

            Console.WriteLine(
                $"\nМиллисекунды: {milliSec}" +
                $"\nСекунды:      {sec}" +
                $"\nМинуты:       {min}" +
                $"\nЧас:          {hour}" +
                $"\nДень:         {day}" +
                $"\nМесяц:        {month}" +
                $"\nГод:          {year}"
                );
            Console.WriteLine();

            Console.WriteLine(time2.Kind);
            Console.WriteLine();

            DateTime time4 = new DateTime(7000, 04, 25, 12, 45, 30);
            DateTime time6 = new DateTime(2019, 04, 25, 12, 45, 30);

            TimeSpan ts = time4.Subtract(time6);

            Console.WriteLine(ts);                       // Какая-то хуета.

            DateTime dt1 = DateTime.Now;
            Console.WriteLine(DateTime.UtcNow);

            Console.WriteLine("{0:ddd dd MMMM yyyy года, tt hh:mm tt}", dt1);
            Console.WriteLine();

            Console.WriteLine("D: " + "{0:D}", dt1);
            Console.WriteLine("d: " + "{0:d}", dt1);
            Console.WriteLine("F: " + "{0:F}", dt1);
            Console.WriteLine("f: " + "{0:f}", dt1);
            Console.WriteLine("G: " + "{0:G}", dt1);
            Console.WriteLine("g: " + "{0:g}", dt1);
            Console.WriteLine("M: " + "{0:M}", dt1);
            Console.WriteLine("m: " + "{0:m}", dt1);
            Console.WriteLine("O: " + "{0:O}", dt1);
            Console.WriteLine("o: " + "{0:o}", dt1);
            Console.WriteLine("R: " + "{0:R}", DateTime.UtcNow);
            Console.WriteLine("r: " + "{0:r}", DateTime.UtcNow);
            Console.WriteLine("s: " + "{0:s}", dt1);
            Console.WriteLine("T: " + "{0:T}", dt1);
            Console.WriteLine("t: " + "{0:t}", dt1);
            Console.WriteLine("U: " + "{0:U}", dt1);
            Console.WriteLine("u: " + "{0:u}", dt1);
            Console.WriteLine("Y: " + "{0:Y}", dt1);
            Console.WriteLine("y: " + "{0:y}", dt1);

        }
    }
}
