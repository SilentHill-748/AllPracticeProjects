using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Graph
{
    class Program
    {
        static int[,] DegreeMatrix(int[,] matrix, int degree)
        {
            if (degree == 1) return matrix;

            if (degree == 0) throw new Exception("Иди нахуй.");

            int counter = 1;

            int[,] result = matrix;

            while (counter < degree)
            {
                result = MultiplyMatrix(result, matrix);
                counter++;
            }

            return result;
        }

        static int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
        {
            int dimention = matrix1.GetLength(0);
            int resultItem = 0;

            int[,] result = new int[dimention, dimention];

            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    for (int x = 0; x < dimention; x++)
                    {
                        resultItem += matrix1[i, x] * matrix2[x, j];
                    }
                    result[i, j] = resultItem;
                    resultItem = 0;
                }
            }

            return result;
        }

        static int[,] SumMatrix(List<int[,]> matrices)
        {
            int[,] result = new int[matrices[0].GetLength(0), matrices[0].GetLength(1)];

            for (int i = 0; i < matrices[0].GetLength(0); i++)
                for (int j = 0; j < matrices[0].GetLength(0); j++)
                {
                    foreach (int[,] matrix in matrices)
                    {
                        result[i, j] += matrix[i, j];
                    }
                }

            return result;
        }

        static void OutputMatrix(int[,] matrix)
        {
            string item;
            string output;
            int range = SetRange(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    item = matrix[i, j].ToString();
                    output = $"{item}".PadLeft(range + 1);
                    
                    Console.Write(output);
                }
                Console.WriteLine();
            }
        }

        static int SetRange(int[,] matrix)
        {
            int range = 0;
            int len;
            foreach (int item in matrix)
            {
                len = item.ToString().Length;
                if (len > range) range = len;
            }

            return range;
        }

        static void GetMatrices(List<int[,]> matrices)
        {
            for (int i = 0; i < matrices.Count; i++)
            {
                OutputMatrix(matrices[i]);
                Console.WriteLine();
            }
        }

        static int[,] SetMatrix(int dimention, params int[] items)
        {
            int[,] matrix = new int[dimention, dimention];
            int counter = 0;
            for (int i = 0; i < dimention; i++)
            {
                for (int j = 0; j < dimention; j++)
                {
                    matrix[i, j] = items[counter];
                    counter++;
                }
            }

            return matrix;
        }
        
        static void Main()
        {
            int[,] E =      SetMatrix(7, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1);
            int[,] matrix = SetMatrix(7, 0, 0,1,1,1,0,0,1,0,0,0,0,1,0,1,0,0,0,0,1,1,1,0,0,0,0,1,1,0,1,0,0,0,0,1,0,1,1,1,1,0,1,1,0,0,0,0,0,0);

            List<int[,]> matrices = new List<int[,]>();
            matrices.Add(E);
            matrices.Add(matrix);
            matrices.Add(DegreeMatrix(matrix, 2));
            matrices.Add(DegreeMatrix(matrix, 3));
            matrices.Add(DegreeMatrix(matrix, 4));
            matrices.Add(DegreeMatrix(matrix, 5));
            matrices.Add(DegreeMatrix(matrix, 6));
            matrices.Add(DegreeMatrix(matrix, 7));

            GetMatrices(matrices);

            OutputMatrix(SumMatrix(matrices));


            Console.ReadLine();
        }
    }
}
