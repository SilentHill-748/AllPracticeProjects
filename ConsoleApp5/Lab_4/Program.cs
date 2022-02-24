using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    // Построить график функции. Функция Y = aX^2 + bX + c

    class Program
    {
        static void SetPoint((int, int) coordinate, int left, int top)
        {
            int x1 = left + coordinate.Item1;
            int x2 = left - coordinate.Item1;
            top -= coordinate.Item2;
            Console.SetCursorPosition(x1, top);
            Console.Write("*");
            Console.SetCursorPosition(x2, top);
            Console.Write("*");
        }

        static (int X, int Y) SetCoordinate(int x, int a, int b, int c)
        {
            int y = a * (x * x) + b * x + c;

            return (x, y);
        }

        
        static void Main()
        {
            int x, a, b, c;
            int left = 20, top = 50;
            Console.WriteLine("Введите a, b и с: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Console.SetCursorPosition(left, top); // Центр оси координат.
            for (x = 0; x < 3; x++)
            {
                var coor = SetCoordinate(x, a, b, c);
                SetPoint(coor, left, top);
            }

            Console.ReadKey();
        }
    }
}
