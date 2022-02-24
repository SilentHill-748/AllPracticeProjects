using System;
using System.IO;

namespace TestApp
{
    // 1.	Получить новый файл из двузначных нечётных элементов исходного.
    // 2.	Получить новый файл из исходного, заменив все чётные элементы на минимальный элемент.
    // 3.	Получить новый файл из исходного, заменив все нечётные элементы на максимальный элемент.
    // 4.	Получить новый файл из исходного, заменив все отрицательные элементы на минимальный элемент.

    class Program
    {
        static void SetNewFile(string path)
        {
            // создаем файл с рандомными значениями
            StreamWriter setNewFile = new StreamWriter(path);
            Random rnd = new Random();
            int randNumber;

            for (var i = 0; i < 10; i++)
            {
                randNumber = rnd.Next(-100, 100);
                setNewFile.WriteLine(randNumber);
            }
            setNewFile.Close();
        }

        static int GetMinItem(string path)
        {
            // Ищем минимальное число в файле.
            StreamReader readFile = new StreamReader(path);
            int minValue = int.MaxValue;

            while(!readFile.EndOfStream)
            {
                string str = readFile.ReadLine();
                int num = int.Parse(str);

                if(num < minValue)
                {
                    minValue = num;
                }
            }

            return minValue;
        }

        static int GetMaxItem(string path)
        {
            // Ищем минимальное число в файле.
            StreamReader readFile = new StreamReader(path);
            int maxValue = int.MinValue;

            while (!readFile.EndOfStream)
            {
                string str = readFile.ReadLine();
                int num = int.Parse(str);

                if (num < maxValue)
                {
                    maxValue = num;
                }
            }

            return maxValue;
        }

        static void Main(string[] args)
        {
            // 1 //
            int minItem;

            SetNewFile(@"File.txt"); // создаем файл

            StreamReader ReadFile = new StreamReader(@"File.txt");
            StreamWriter WriteFile = new StreamWriter(@"Result.txt");

            while (!ReadFile.EndOfStream)
            {
                minItem = GetMinItem(@"File.txt"); // нашли мин число

                string str = ReadFile.ReadLine();
                int num = int.Parse(str);

                if (num < 0)
                {
                    WriteFile.WriteLine(minItem); //каждое отрицательное число заменим на мин число
                }
                else
                {
                    WriteFile.WriteLine(num);
                }
            }
            WriteFile.Close();
            ReadFile.Close();
        }
    }
}
