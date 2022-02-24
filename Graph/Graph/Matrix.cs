using System;
using System.Runtime.InteropServices;

namespace Graph
{
    internal class Matrix
    {
        // Размерность матрицы
        private int columns;  //столбцы
        private int strings;  // Строки
        private int[,] matrix;

        public Matrix(int[,] matrix)
        {
            this.matrix = matrix;
            strings = matrix.GetLength(0);
            columns = matrix.GetLength(1);
        }

        public Matrix(int strings, int columns)
        {
            this.matrix = new int[strings, columns];
        }

        public Matrix(int dimension)
        {
            this.matrix = new int[dimension, dimension];
            this.strings = dimension;
            this.columns = dimension;
        }

        public void GetMatrix(int[] matrix)
        {
            
        }
    }
}
