using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace Lab_3
{
    class Program
    {
        static void GetMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ".PadLeft(4));
                }
                Console.WriteLine();
            }
        }

        static int[,] CalculateSquare(int dimention)
        {
            int[,] s = SetSquare(dimention);
            return ConvertResultSquare(s, dimention);
        }

        static int[,] SetSquare(int dimention)
        {
            int newDimention = dimention * 2 - 1;
            int[,] matrix = new int[newDimention, newDimention];
            int beginStateY = dimention - 1;
            int beginStateX = 0;
            int counter = 0;
            int number = 1;

            while (number < Math.Pow(dimention, 2))
            {
                int x = beginStateX;
                int y = beginStateY;

                while (counter < dimention)
                {
                    matrix[y, x] = number;
                    x++;
                    y--;
                    number++;
                    counter++;
                }
                beginStateY++;
                beginStateX++;
                counter = 0;
            }

            return matrix;
        }

        static void GetSquare(ref int[,] matrix, int dimention)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        if (i < dimention / 2)
                            Swap(matrix, i, j, i + dimention, j);
                        else if (i > dimention / 2 * 3)
                            Swap(matrix, i, j, i - dimention, j);

                        if (j < dimention / 2)
                            Swap(matrix, i, j, i, j + dimention);
                        else if (j > dimention / 2 * 3)
                            Swap(matrix, i, j, i, j - dimention);
                    }
                }
            }
        }

        static int[,] ConvertResultSquare(int[,] matrix, int dimention)
        {
            int[,] result = new int[dimention, dimention];

            GetSquare(ref matrix, dimention);

            int x = 0, y = 0;
            for (int i = dimention / 2; i < matrix.GetLength(0); i++)
            {
                for (int j = dimention / 2; j < matrix.GetLength(1); j++)
                {
                    if (i <= dimention / 2 * 3 && j <= dimention / 2 * 3)
                    {
                        result[y, x] = matrix[i, j];
                        x++;
                    }
                }
                y++;
                x = 0;
            }

            return result;
        }

        static void Swap(int[,] matrix, int oldY, int oldX, int newY, int newX)
        {
            int temp;

            temp = matrix[oldY, oldX];
            matrix[oldY, oldX] = 0;
            matrix[newY, newX] = temp;
        }

        static void Main()
        {
            Console.Write("Укажите размер квадрата (нечетное число): ");
            int dimention = Convert.ToInt32(Console.ReadLine());
            int[,] square = CalculateSquare(dimention);

            Console.WriteLine();
            GetMatrix(square);

            Console.ReadKey();
        }   
    }
}
