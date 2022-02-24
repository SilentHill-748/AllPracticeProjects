using System;
using System.Diagnostics;

namespace Algorithms.Sorts
{
    /// <summary>
    /// Представляет шейкерный алгоритм сортировки.
    /// </summary>
    class Cocktail : AlgorithmBase
    {
        private int[] array;

        public TimeSpan Time { get; private set; }

        public Cocktail(int[] array)
        {
            this.array = array;

            CocktailSort(ref this.array);
        }

        private void CocktailSort(ref int[] array)
        {
            var timer = new Stopwatch();

            timer.Start();

            int left = 0;
            int right = array.Length - 1;
            int swapCount = 0;

            while (left < right)
            {
                MoveRight(array, left, right);
                swapCount++;
                right--;

                if (swapCount == 0)
                {
                    break;
                }

                MoveLeft(array, left, right);
                swapCount++;
                left++;

                if (swapCount == 0)
                {
                    break;
                }

                swapCount = 0;
            }

            timer.Stop();
            Time = timer.Elapsed;
        }

        private void MoveLeft(int[] array, int left, int right)
        {
            for (var i = right; i > left; i--)
            {
                if (array[i].CompareTo(array[i - 1]) == -1)
                {
                    Swap(i, i - 1, array);
                }
            }
        }

        private void MoveRight(int[] array, int left, int right)
        {
            for (var i = left; i < right; i++)
            {
                if (array[i].CompareTo(array[i + 1]) == 1)
                {
                    Swap(i, i + 1, array);
                }
            }
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
