using System;
using System.Diagnostics;
using System.Threading;
using Algorithms.Sorts;

namespace Algorithms
{ 
    class Program
    {
        static void SetArray(ref int[] array)
        {
            var rnd = new Random();

            for(var i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(-100, 100);
            }
        }

        static void GetArray(int[] array)
        {
            Console.WriteLine("Исходный массив: ");

            for(var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }

        static void Main(string[] args)
        {
            int[] array = new int[500];
            SetArray(ref array);
            GetArray(array);
            Console.WriteLine();

            Bubble sort = new Bubble(array);
            Console.WriteLine(sort);
            Console.WriteLine("\nЗатрачено времени: " + sort.Time.TotalMilliseconds * 10 + " нс");

            Console.ReadLine();
        }
    }
}
