using System;
using System.Text.RegularExpressions;

namespace Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Road road = new();
            string text = "123";
            bool result = text.IsEvenLength();
            Console.WriteLine(road.GetFive());
        }
    }

    internal class Road
    {
        public int GetFive()
        {
            Console.WriteLine("Is Road");
            return 5;
        }
    }

    public static class Extensions
    {
        public static bool IsEvenLength(this string text)
        {
            return text.Length % 2 == 0;
        }

        public static int GetFive()
        {
            Console.WriteLine("Is Road");
            return 5;
        }
    }
}
