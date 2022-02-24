using System;

namespace Swapping
{
    // Swap two elements of array without using third variable.
    class Program
    {
        static readonly string[] array = new string[] { "1", "0.4", "V", "sdsd" };

        static void Main()
        {
            Swap(2, 0);
            GetArray(); // V; 0.4; 1; sdsd; <- Ожидаем увидеть.
            Console.ReadKey();
        }

        static void Swap(int id1, int id2)
        {
            string s1 = array[id1];
            string s2 = array[id2];

            array[id1] = s2;
            array[id2] = s1;
        }

        static void GetArray()
        {
            foreach (string o in array)
                Console.Write($"{o}; ");
            Console.WriteLine();
        }
    }
}

