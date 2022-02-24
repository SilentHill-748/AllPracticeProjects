using System;

namespace ConsoleApp4
{
    class Program
    {
        static int countOfZ;

        static void Main()
        {
            Console.Write("Введите количество множества: ");
            countOfZ = int.Parse(Console.ReadLine());

            GetTable();
        }

        static void GetTable()
        {
            for (int i = 0; i < countOfZ; i++)
            {
                for (int j = 0; j < countOfZ; j++)
                    Console.Write($"{i * j % countOfZ}".PadLeft(4));
                Console.WriteLine();
            }
        }
    }
}
