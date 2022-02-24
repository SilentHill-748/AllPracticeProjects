using System;
using System.IO;
using System.Collections.Generic;

namespace LabForVlad
{
    // Элементы файла могут принимать целые значения от 0 до 100. 
    // Опишите алгоритм, позволяющий найти и вывести произведение двузначных элементов файла, которые не делятся на 6. 
    // Гарантируется, что в исходном файле есть хотя бы один такой элемент.

    class Program
    {
        static void Main()
        {
            decimal multiplyNums = 1m;
            string str; // буфер
            int num; // буфер

            SetFile(@"Start.txt");

            StreamReader reader = new StreamReader(@"Start.txt");
            while(!reader.EndOfStream)
            {
                str = reader.ReadLine();
                num = int.Parse(str);

                if(num % 6 != 0 && num > 9)
                {
                    multiplyNums *= num;
                }
            }
            reader.Close();

            Console.WriteLine("Произведение двузначных чисел, не делящихся на 6 - " + multiplyNums);
        }

        static void SetFile(string path)
        {
            Random rnd = new Random();

            using (StreamWriter writer = new StreamWriter(path))
            {
                for(var i = 0; i < 15; i++)
                {
                    writer.WriteLine( rnd.Next(101) );
                }
                writer.WriteLine(35); // Прописываем гарантию того, что в файле как минимум 1 число отвечает условию.
            }
        }
    }
}
