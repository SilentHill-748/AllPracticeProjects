using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Sorts
{
    // TODO: Класс ArraySort не дописан!

    /// <summary> Static class encapsulated main sort algorithms. </summary>
    public static class ArraySort
    {
        private static Random _rnd;


        static ArraySort()
        {
            _rnd = new Random();
        }


        public static void BubbleSort(List<int> collection)
        {
            for (var i = 0; i < collection.Count; i++)
                for (var j = 0; j < collection.Count - 1; j++)
                {
                    if (collection[j] > collection[j + 1])
                    {
                        int temp = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = temp;
                    };
                }
        }

        public static void InsertionSort(List<int> collection)
        {
            // We build the collection in sorted order by inserting the necessary elements in their places.
            for (int i = 1; i < collection.Count; i++)
                for (int j = i; j > 0 && collection[j] < collection[j - 1]; j--)
                {
                    int temp = collection[j];
                    collection[j] = collection[j - 1];
                    collection[j - 1] = temp;
                }
        }

        public static void CoctailSort(List<int> collection)
        {
            int min = 0, max = collection.Count - 1; // Setup borders of array.

            for (int k = 0; k < collection.Count; k++)
            {
                // Bypass to right and left until swapping doesn't stop.
                if (ToRight(collection, min, ref max)) break;
                if (ToLeft(collection, max, ref min)) break;     
            }
        }

        /// <summary> Sort by Shell. </summary>
        public static void ShellSort(List<int> collection)
        {
            int step = collection.Count / 2;
            while (step > 0)
            {
                for (var i = step; i < collection.Count; i++)
                {
                    int j = i;
                    // Consistently compare the elements of the groups.
                    while ((j >= step) && collection[j-step] > collection[j])
                    {
                        int temp = collection[j - step];
                        collection[j - step] = collection[j];
                        collection[j] = temp;
                        j -= step;
                    }
                }
                step /= 2;
            }
        }

        /// <summary> Quick sort by Hoara. </summary>
        public static List<int> QuickSort(List<int> collection)
        {
            int count = collection.Count();

            if (count < 2)
                return collection;

            int politIndex = _rnd.Next(count / 2);
            int polit = collection[politIndex];

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (i == politIndex)
                    continue;

                if (collection[i].CompareTo(polit) <= 0)
                    left.Add(collection[i]);
                else
                    right.Add(collection[i]);
            }

            List<int> sortedLeft = QuickSort(left);
            List<int> sortedRight = QuickSort(right);

            return sortedLeft.Append(polit).Concat(sortedRight).ToList();
        }

        public static void QuickSort2(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int partition = Partition(arr, left, right);
                QuickSort2(arr, left, partition);
                QuickSort2(arr, partition + 1, right);
            }
        }

        private static int Partition(int[] arr, int left, int right)
        {
            int value = arr[(left + right) / 2];
            int i = left;
            int j = right;

            while (i <= j)
            {
                while (arr[i] < value)
                    i++;

                while (arr[j] > value)
                    j--;

                if (i >= j)
                    break;

                Swap(ref arr[i++], ref arr[j--]);
            }

            return j;
        }

        private static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Bypass to left in coctail sort.
        private static bool ToRight(List<int> collection, int min, ref int max)
        {
            int counter = 0;                // Swap counter.
            for (var i = min; i < max; i++)
                if (collection[i] > collection[i + 1])
                {
                    int temp = collection[i];
                    collection[i] = collection[i + 1];
                    collection[i + 1] = temp;
                    counter++;
                }
            max--;
            if (counter == 0) return true;
            return false;
        }

        // Bypass to right in coctail sort.
        private static bool ToLeft(List<int> collection, int max, ref int min)
        {
            int counter = 0; 
            for (var j = max; j > min; j--)
                if (collection[j] < collection[j - 1])
                {
                    int temp = collection[j];
                    collection[j] = collection[j - 1];
                    collection[j - 1] = temp;
                    counter++;
                }
            min++;
            if (counter == 0) return true; 
            return false;
        }
    }
}