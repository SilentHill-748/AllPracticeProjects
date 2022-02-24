using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary1;

namespace StringSort
{
    class Program
    {
        delegate void Tester();

        static void Main()
        {
            object testIntItem = 8;
            Console.WriteLine(testIntItem.GetType());
            string s = testIntItem.ToString();
            int testInt = Convert.ToInt32(s);
            Console.WriteLine(testInt);
        }
        static void t() { }

        static int BinarySearch(int[] array, int target)
        {
            if (!array.Contains(target))
                throw new Exception($"Не то ищешь! {target} Отсутствует в массиве!");

            int left = 0;
            int right = array.Length - 1;
            while (true)
            {
                int avg = (left + right) / 2;
                if (target == array[avg]) return array[avg];

                if (array[avg] < target)
                    left = avg;
                else
                    right = avg;

                if (right - left == 1)
                    ReturnFindedItem(array[left], array[right], target);
            }
        }

        static int ReturnFindedItem(int left, int right, int target)
        {
            if (target == left)
                return left;
            return right;
        }
    }

    class Fibonacci
    {
        private readonly List<long> _basis;
        private readonly long _hexValue;
        private IEnumerable<char> _fibValue;

        public Fibonacci(long value)
        {
            _basis = new List<long>();
            _hexValue = value;
            _fibValue = string.Empty;

            BuildBasis();
        }

        public string HexToFib()
        {
            if (_hexValue == 0) return "";

            long temp = _hexValue;
            for (int i = _basis.Count - 1; i >= 0; i--)
            {
                FillFibonacciCode(ref temp, _basis[i]);
            }
            return string.Join(null, _fibValue);
        }

        private void FillFibonacciCode(ref long fibNum, long numOfBasic)
        {
            if (numOfBasic == 0 || fibNum - numOfBasic < 0)
                _fibValue = _fibValue.Prepend('0');
            else
            {
                fibNum -= numOfBasic;
                _fibValue = _fibValue.Prepend('1');
            }
        }

        private void BuildBasis()
        {
            double sqrt5 = Math.Sqrt(5);
            for (int i = 2; true; i++)
            {
                double temp = (Math.Pow((1 + sqrt5) / 2, i) - Math.Pow((1 - sqrt5) / 2, i)) / sqrt5;
                long fibNum = (long)Math.Round(temp);
                if (fibNum > _hexValue) return;
                _basis.Add(fibNum);
            }
        }
    }
}
