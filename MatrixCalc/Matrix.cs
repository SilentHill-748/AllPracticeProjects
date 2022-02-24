using System;

namespace MatrixCalc
{
    internal class Matrix : ICloneable
    {
        private int[,] items;

        public int Size { get; private set; }

        public int this[int row, int column]
        {
            get => items[row, column];
            set => items[row, column] = value;
        }
        public Matrix()
        {
        }

        public Matrix(int size)
        {
            Size = size;
            this.items = new int[Size, Size];
        }

        public Matrix(int[,] data)
        {
            Size = data.GetLength(0);
            this.items = data;
        }

        public void InputData(int[,] data)
        {
            items = data;
        }

        public void Transpose()
        {
            int[,] temp = new int[Size, Size];

            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    temp[j, i] = items[i, j];
            items = temp;
        }

        // Нахождение определителя по формуле "Разложение по строке".
        public long GetDeterminant()
        {
            if (Size == 1) return items[0, 0];
            if (Size == 2) return GetDeterminantMinor(this);

            long detMatrix = 0;
            long detMinor;
            Matrix minor = this;

            for (int i = 0; i < Size; i++)
            {
                // Если матрица выше 3 порядка, то рекурсивно вызываем для n-1 порядка. 
                if (minor.Size > 3)
                    detMinor = SetMinor(i, minor).GetDeterminant();
                else
                {
                    // Если матрица получилась 3 порядка, считаем определитель её миноров по 1 строке.
                    var tempMinor = SetMinor(i, minor);
                    detMinor = GetDeterminantMinor(tempMinor);
                }

                // полученные определители миноров матрицы 3 порядка подставляем в формулу разложения.
                // k - коэффициент, равный (-1)^(1+j), где j - номер элемента в 1 строке матрицы.
                // подставил 2+i, вместо 1+i, т.к. отчет в формуле идет от 1, а в программировании индексация идет от 0.
                int k = (int)Math.Round(Math.Pow(-1, 2 + i)); 
                detMatrix += k * items[0, i] * detMinor; // Финальная формула.
            }
            return detMatrix;
        }

        public void Clear()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    items[i, j] = 0;
        }

        public object Clone()
        {
            return new Matrix()
            {
                items = (int[,])items.Clone(),
                Size = this.Size
            };
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size)
                throw new Exception("Матрицы не равны по размеру!");

            int size = matrix1.Size;
            Matrix result = new Matrix(matrix1.Size);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = matrix1[i, j] + matrix2[i, j]; 

            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size)
                throw new Exception("Матрицы не равны по размеру!");

            int size = matrix1.Size;
            Matrix result = new Matrix(matrix1.Size);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    result[i, j] = matrix1[i, j] - matrix2[i, j];

            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Size != matrix2.Size)
                throw new Exception("Матрицы не равны по размеру!");

            int temp = 0;
            int size = matrix1.Size;
            Matrix result = new Matrix(matrix1.Size);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                        temp += matrix1[i, k] * matrix2[k, j];
                    result[i, j] = temp;
                    temp = 0;
                }

            return result;
        }

        // Находение минора матрицы, удаляя из исходной матрицы 1 строку и k-ый столбец.
        private Matrix SetMinor(int k, Matrix matrix)
        {
            Matrix minor = new Matrix(matrix.Size - 1);

            for (int i = 1, l = 0; i < matrix.Size; i++, l++)
                for (int j = 0, r = 0; j < matrix.Size; j++)
                {
                    if (j == k) continue;

                    minor[l, r] = this.items[i, j];
                    r++;
                }

            return minor;
        }

        // Расчет определителя минора 2 порядка.
        private long GetDeterminantMinor(Matrix minor)
        {
            long det = minor[0, 0] * minor[1, 1] - minor[0, 1] * minor[1, 0];
            return det;
        }
    }
}