//Дано 4-х значное число. Разложить его на 2-3 простых множителя всеми способами

using System;
using System.Collections.Generic;

namespace Program1
{
    class Program
    {
        static void Main()
        {
            int num, del, i, j;
            List<string> output = new List<string>();
            List<int> lst = new List<int>();

            Console.WriteLine("Введите 4-х значное число");
            num = int.Parse(Console.ReadLine());                //Вводим 4-х значное число

            for (i = 2; i <= num; i++)                          //Перебираем числа от 2 до n
            {
                del = 0;
                for (j = 2; j <= i; j++)                        //Проверяем текущее число на простое. От 2 до i
                    if (i % j == 0)                             //Если i % j = 0. Число должно делиться один раз, только на само себя
                        del++;                                  //Если del = 1 - число простое. Если больше - не подходит
                if (del == 1)
                {
                    lst.Add(i);                                 //По итогу составляется список простых чисел от 2 до n
                }
            }

            for (i = 0; i < lst.Count; i++)                     //Перебираем все элементы списка простых чисел чтобы найти целочилсенные делители числа n
            {
                if (num % lst[i] != 0)                          //Если появляется остаток при делении n на простое число, то данное простое число не является делителем n - выкидываем
                {
                    lst.RemoveAt(i);
                    i--;
                }
            }                                                   //Получили список простых делителей числа n

            Console.WriteLine($"Число {num} раскладывается на следующие простые множители:");
            for (i = 0; i < lst.Count; i++)
                Console.WriteLine(lst[i]);
        }
    }
}
