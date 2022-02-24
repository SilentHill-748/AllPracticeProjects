using System;
using System.Diagnostics;

namespace Algorithms.Sorts
{
    /// <summary>
    /// Представляет алгоритм сортировки вставками.
    /// </summary>
    class Insert : AlgorithmBase
    {
        private int[] array;

        public TimeSpan Time { get; private set; }

        public Insert(int[] array)
        {
            this.array = array;

            InsertionSort(ref this.array);
        }

        private void InsertionSort(ref int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();

            for (var i = 1; i < array.Length; i++)
            {
                for (var j = i; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        Swap(j, j - 1, array);
                    }
                }
            }
            timer.Stop();
            Time = timer.Elapsed;
        }

        public override string ToString()
        {
            Console.WriteLine("\nОтсортированный массив: ");

            for (var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            return "\n Конец сортировки.";
        }
    }
}
