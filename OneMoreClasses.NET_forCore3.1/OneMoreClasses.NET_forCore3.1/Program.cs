using System;

namespace OneMoreClasses.NET_forCore3._1
{
    class Program
    {
        static void Main()
        {
            // Индексы и диапазоны.
            Index ind1 = 5;
            Index ind2 = ^3;

            Index start = 1;
            Index end = 8;
            Range range = start..end; // 1..8 == [1 2 3 4 5 6 7]

            int indexValue = start.Value;
            Console.WriteLine(indexValue); // 1

            var array = new int[10];
            SetArray(array);

            Console.WriteLine(array[ind1]); // 6
            Console.WriteLine(array[ind2]); // 8
            Console.WriteLine(array[^3]);   // 8

            int[] newArr = array[range];
            GetArray(array);    // 1 2 3 4 5 6 7 8 9 10
            GetArray(newArr);   // 2 3 4 5 6 7 8


            int x = end.GetOffset(array.Length);
            Console.WriteLine(x);
            //Console.WriteLine(array[myIndex]);  // 4

            Console.Read();
        }

        static void SetArray(int[] array)
        {
            int item = 0;

            for (int i = 0; i < array.Length; i++)
            {
                item++;
                array[i] += item;
            }
        }

        static void GetArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
