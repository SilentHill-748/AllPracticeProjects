using System;
using System.Collections.Generic;

namespace Lab_1
{
    // Дано хххх число. Разложить его на 2-3 множителя простых чисел. Простое число - число, которое делится на 1 или на само себя.
    class Example
    {
        static void Main()
        {
            uint pool;
            uint number;
            string temp;
            List<int> primeNumbers = new List<int>();

            Console.Write("Введите число диапазона значений, среди которого будет проведет поиск простых чисел: ");
            temp = Console.ReadLine();
            pool = Convert.ToUInt32(temp);

            SetPrimeNumbers(primeNumbers, pool);

            Console.Write("\nВведите четырехзначное число: ");
            temp = Console.ReadLine();
            number = Convert.ToUInt32(temp);

            SetFactors(primeNumbers, number);

            Console.ReadLine();
        }

        static void SetFactors(List<int> primeNumbers, uint number)
        {
            int counter = 0;
            int result;

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                for (int j = 0; j < primeNumbers.Count; j++)
                {
                    if (primeNumbers[i] * primeNumbers[j] == number)
                    {
                        result = primeNumbers[i] * primeNumbers[j];
                        counter++;
                        Console.WriteLine($"Пара {counter} ({primeNumbers[i]} * {primeNumbers[j]} = {result}) ");
                    }
                }
            }
        }

        // Проверяем, является ли число простым
        static void SetPrimeNumbers(List<int> primeNumbers, uint pool)
        {
            int prime;
            int counter = 0;

            for (prime = 1; prime < pool; prime++)
            {
                for (int j = 1; j != prime + 1; j++)
                    if (prime % j == 0) counter++;

                if (counter <= 2 && counter > 0) primeNumbers.Add(prime);
                counter = 0;
            }
        }
    }
}
