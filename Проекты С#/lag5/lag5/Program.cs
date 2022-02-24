using System;
using System.Collections.Generic;

namespace lag5
{
    /*
     * Дано натуральное число n и целые числа a1,a2,...,an. Вычислить минимальное |Aj - Aср|, где Aср - среднее арифметическое чисел a1,...,an.
     * 1 <= j <= n
     */
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<int> list = new List<int>(); //последовательность в виде списка
            int n; // число элементов
            int elem; // элемент списка (а1, а2...)

            Console.Write("Введите число n: ");
            n = int.Parse(Console.ReadLine());

            int j;
            for( j = 1; j <= n; j++ ) //заполнение последовательности
            {
                elem = rand.Next(-1000, 1000);
                list.Add(elem);
            }

            //найдем среднее арифметическое Аср
            int sum = 0;
            int sr = 0;
            for( j = 1; j <= n; j++ )
            {
                sum += list[j - 1];
                sr = sum / n;
            }

            // найдем модуль из условия.
            int min = 1000;
            int modul;
            for( j = 0; j < n; j++ )
            {
                modul = Math.Abs(list[j] - sr);
                if (modul < min)
                    min = modul;
            }

            Console.WriteLine("Минимальный модуль |Aj - Aср| = {0}", min);
        }
    }
}
