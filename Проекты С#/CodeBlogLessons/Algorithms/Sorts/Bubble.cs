using System;
using System.Diagnostics;

namespace Algorithms.Sorts
{
    /// <summary>
    /// Представляет алгоритм сортировки пузырьком.
    /// </summary>
    class Bubble : AlgorithmBase
    {
        private int[] array;

        public TimeSpan Time { get; private set; }

        public Bubble(int[] array)
        {
            this.array = array;

            Sort(ref this.array);
        }

        /// <summary>
        /// Производит сортировку и фиксирует время выполнения.
        /// </summary>
        /// <param name="array"></param>
        private void Sort(ref int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();
            for (var i = 0; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(j, j + 1, array);
                    }
                }
            }
            timer.Stop();
            Time = timer.Elapsed;
        }

        public override string ToString()
        {
            Console.WriteLine("\nОтсортированный массив: ");

            for(var i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            return "\n Конец сортировки.";
        }
    }
}
