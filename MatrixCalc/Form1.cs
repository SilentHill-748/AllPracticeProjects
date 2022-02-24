using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class Form1 : Form
    {
        private Matrix matrixA;
        private Matrix matrixB;
        private List<long> determinants;  // Коллекция определителей матриц.

        public Form1()
        {
            InitializeComponent();

            ADeterminantL.Text = "";
            BDeterminantL.Text = "";
        }

        private void SetSize(DataGridView dataGrid, int sizeMatrix)
        {
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();

            for (int i = 0; i < sizeMatrix; i++)
            {
                dataGrid.Columns.Add("", "");
                dataGrid.Rows.Add();
            }
        }

        private void SetProperties(DataGridView dataGridView)
        {
            dataGridView.RowHeadersWidth = 30;
            dataGridView.AllowUserToAddRows = false;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
                dataGridView.Columns[i].Width = 30;
        }

        private void AMatrixSizeCB_TextChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            int size = int.Parse(cb.SelectedItem.ToString());

            SetSize(AMatrixDGV, size);
            SetProperties(AMatrixDGV);
        }

        private void BMatrixSizeCB_TextChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            int size = int.Parse(cb.SelectedItem.ToString());

            SetSize(BMatrixDGV, size);
            SetProperties(BMatrixDGV);
        }

        private void FillMatrix(DataGridView dataGrid, ref Matrix matrix)
        {
            int size = dataGrid.Rows.Count;
            matrix = new Matrix(size);

            for (int i = 0; i < size; i++ )
                for (int j = 0; j < size; j++)
                {
                    string value = dataGrid?.Rows[i]?.Cells[j]?.Value?.ToString();
                    matrix[i, j] = int.Parse(value);
                }
        }

        private void ADeterminantB_Click(object sender, EventArgs e)
        {
            if (!CheckInputDGV(BMatrixDGV)) return;

            FillMatrix(AMatrixDGV, ref matrixA);
            string detA = matrixA.GetDeterminant().ToString();
            ADeterminantL.Text = "Determinant A = " + detA;
        }

        private void ATransposeB_Click(object sender, EventArgs e)
        {
            if (!CheckInputDGV(AMatrixDGV))
                return;
            else
            {
                FillMatrix(AMatrixDGV, ref matrixA);
                matrixA.Transpose();
                FillDataGrid(ResultDGV, matrixA);
            }
        }

        private void FillDataGrid(DataGridView dataGrid, Matrix matrix)
        {
            SetSize(dataGrid, matrix.Size);
            SetProperties(dataGrid);

            for (int i = 0; i < matrix.Size; i++)
                for (int j = 0; j < matrix.Size; j++)
                    dataGrid.Rows[i].Cells[j].Value = matrix[i, j];
        }

        private bool CheckInputDGV(DataGridView dataGrid)
        {
            int size = dataGrid.Rows.Count;
            if (size == 0) return false;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    string value = dataGrid?.Rows[i]?.Cells[j]?.Value?.ToString();
                    if (string.IsNullOrEmpty(value))
                        return false;
                }
            return true;
        }

        private void BTransposeB_Click(object sender, EventArgs e)
        {
            if (!CheckInputDGV(BMatrixDGV))
                return;
            else
            {
                FillMatrix(BMatrixDGV, ref matrixB);
                matrixB.Transpose();
                FillDataGrid(ResultDGV, matrixB);
            }
        }

        private void BDeterminantB_Click(object sender, EventArgs e)
        {
            if (!CheckInputDGV(BMatrixDGV)) return;

            FillMatrix(BMatrixDGV, ref matrixB);
            string detB = matrixB.GetDeterminant().ToString();
            BDeterminantL.Text = "Determinant B = " + detB;
        }

        private void CalcOperationB_Click(object sender, EventArgs e)
        {
            if (AMatrixDGV.Columns.Count != BMatrixDGV.Columns.Count)
            {
                MessageBox.Show("Вы вводите матрицы разного размера!", "Ошибка");
                return;
            }

            if (CheckInputDGV(AMatrixDGV) && 
                CheckInputDGV(BMatrixDGV))
            {
                FillMatrix(AMatrixDGV, ref matrixA);
                FillMatrix(BMatrixDGV, ref matrixB);
            }
            StartOperaton();
        }

        private void StartOperaton()
        {
            string op = (string)OperationCB.SelectedItem;
            if (op == "") return;

            Matrix matrix;
            switch (op)
            {
                case "A + B": 
                    matrix = matrixA + matrixB; 
                    break;
                case "A - B": 
                    matrix = matrixA - matrixB; 
                    break;
                case "A x B": 
                    matrix = matrixA * matrixB; 
                    break;
                case "A x B - B x A": 
                    matrix = (matrixA * matrixB) - (matrixB * matrixA); 
                    break;
                default: 
                    MessageBox.Show("Укажите операцию", "Ошибка");
                    return;
            }

            FillDataGrid(ResultDGV, matrix);
        }

        private void AddMatrixB_Click(object sender, EventArgs e)
        {
            if (determinants is null) determinants = new List<long>();

            Matrix matrix = new Matrix();
            FillMatrix(MatrixForSortDGV, ref matrix);
            determinants.Add(matrix.GetDeterminant());
            OutputMatrixCollection();
        }

        // Сортировка алгоритмом Шелла.
        private void SortB_Click(object sender, EventArgs e)
        {
            int step = determinants.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < determinants.Count; i++)
                {
                    int j = i;
                    while (j >= step )
                    {
                        if (determinants[j - step].CompareTo(determinants[j]) == 1)
                        {
                            var temp = determinants[j - step];
                            determinants[j - step] = determinants[j];
                            determinants[j] = temp;
                        }

                        j -= step;
                    }
                }
                step /= 2;
            }

            OutputMatrixCollection();
        }

        private void MatrixSizeCB_TextChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            int size = int.Parse($"{cb.SelectedItem}");

            SetSize(MatrixForSortDGV, size);
            SetProperties(MatrixForSortDGV);
        }

        private void OutputMatrixCollection()
        {
            string collection = "";
            for (int i = 0; i < determinants.Count; i++)
                collection += $"{determinants[i]} ";
            MatrixCollectionL.Text = "Массив матриц: " + collection;
        }

        private void SizeCB_TextChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;
            int size = int.Parse($"{cb.SelectedItem}");

            SetSize(size+1, size, ValuesDGV);
            SetProperties(ValuesDGV);
        }

        private void SetSize(int columns, int rows, DataGridView dataGrid)
        {
            dataGrid.Columns.Clear();
            dataGrid.Rows.Clear();

            for (int i = 0; i < columns; i++)
                dataGrid.Columns.Add("", "");

            for (int i = 0; i < rows; i++)
                dataGrid.Rows.Add();
        }

        private void CalcValuesB_Click(object sender, EventArgs e)
        {
            // разбить грид на 2 коллекции.               +
            // матрицу и столбец со значениями уравнений. +
            // по методу крамера найти N определителей, где N = размеру матрицы или числу уравнений.
            // по результатм определителей найти значение неизвестной делемением ее определителя на главный определитель.
            // Пиздец.

            if (!CheckInputDGV(ValuesDGV)) return;
            
            string[] unkValues = 
                { "X = ", "Y = ", "Z = ", "K = ", "L = ", "I = ", "C = ", "D = ", "S = ", "P = " };
            int[] values = new int[ValuesDGV.Rows.Count];
            Matrix matrix = new Matrix();

            FillMatrix(ValuesDGV, ref matrix);
            SetValuesEquation(values);

            long detMain = matrix.GetDeterminant();
            long detN;
            double result;
            string[] lines = new string[matrix.Size];

            for (int i = 0; i < matrix.Size; i++)
            {
                detN = SetMatrixUnknownValue(i, values, (Matrix)matrix.Clone()).GetDeterminant();
                result = (double)detN / detMain;
                lines[i] = $"{unkValues[i]}{result:F2}";
            }
            ResultTB.Lines = lines;
        }

        private void SetValuesEquation(int[] values)
        {
            int size = ValuesDGV.Rows.Count;
            for (int i = 0; i < size; i++)
                values[i] = int.Parse($"{ValuesDGV?.Rows[i]?.Cells[size]?.Value}");
        }

        // Установка матрицы при неизвестной
        private Matrix SetMatrixUnknownValue(int numUnkValue, int[] values, Matrix mainMatrix)
        {
            Matrix matrix = (Matrix)mainMatrix.Clone();
            for (int i = 0; i < values.Length; i++)
                matrix[i, numUnkValue] = values[i];
            
            return matrix;
        }
    }
}