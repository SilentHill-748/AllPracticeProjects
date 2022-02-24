using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using WorkWithGraphs.Model;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private Graph A;
        private Graph B;
        private Graph nullGraph;
        private Graph fullGraph;

        public Form1()
        {
            InitializeComponent();
            MainGraphStatsL.Text = "";
            SecondaryGraphStatsL.Text = "";
            InfoLabelA.Text = "";
            InfoLabelB.Text = "";
        }

        #region Методы создания графов А и В
        // Определяет размер графа A и отрисовывает поле ввода матрицы.
        private void SizeGraphCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainGraphStatsL.Text = "";
            A = null;
            MainGraph.Visible = true;
            MainGraph.Focus();

            int size = int.Parse((string)SizeGraphCB.SelectedItem);
            InitMainGraph(MainGraph, size);
        }

        // Определяет размер графа В и отрисовывает поле ввода матрицы.
        private void SizeSecondaryGraphCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SecondaryGraphStatsL.Text = "";
            B = null;
            SecondaryGraph.Visible = true;
            SecondaryGraph.Focus();

            int size = int.Parse((string)SizeSecondaryGraphCB.SelectedItem);
            InitMainGraph(SecondaryGraph, size);
        }

        // Отрисовка поля ввода матрицы
        private void InitMainGraph(DataGridView data, int size)
        {
            data.AllowUserToAddRows = false;
            data.AllowUserToResizeColumns = false;
            data.AllowUserToResizeRows = false;
            data.RowHeadersVisible = false;
            data.ColumnHeadersVisible = false;

            CreateDataGrid(data, size);
        }

        private int GetWidthColumns(DataGridView data)
        {
            int width = 0;
            for (int i = 0; i < data.Columns.Count; i++)
                width += data.Columns[i].Width;
            return width;
        }

        private int GetHeigthColumns(DataGridView data)
        {
            int heigth = 0;
            for (int i = 0; i < data.Rows.Count; i++)
                heigth += data.Rows[i].Height;
            return heigth;
        }

        // Создает таблицу с числом равным числом строк и столбцов.
        private void CreateDataGrid(DataGridView data, int size)
        {
            data.Columns?.Clear();
            data.Rows?.Clear();

            for (int i = 0; i < size; i++)
            {
                data.Columns.Add($"{i + 1}", "");
                data.Columns[i].Width = 20;

                data.Rows.Add();
                data.Rows[i].Height = 20;
            }

            data.Width = GetWidthColumns(data);
            data.Height = GetHeigthColumns(data);
            data.Size = new Size(data.Width + 3, data.Height + 3); // Задает размер контрола по размеру полей.
        }

        private void CreateMainGraphB_Click(object sender, EventArgs e)
        {
            try
            {
                bool[,] table = BuildAdjecencyTable(MainGraph);
                CreateGraph(ref A, table);
                CreateGraph(ref nullGraph, false);                  // пустой и полный будут строится по главному графу.
                CreateGraph(ref fullGraph, true);

                if (B != null)
                {
                    OperationsOnGraphs.Enabled = true;
                    OperationsOnSubgraphs.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        private void CreateSecondaryGraphB_Click(object sender, EventArgs e)
        {
            try
            {
                bool[,] table = BuildAdjecencyTable(SecondaryGraph);
                CreateGraph(ref B, table);

                if (A != null)
                {
                    OperationsOnGraphs.Enabled = true;
                    OperationsOnSubgraphs.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        #endregion

        #region Операции над графами А и В
        // Операция пересечения
        private void CrossingMenuItem_Click(object sender, EventArgs e)
        {
            if (A is null || B is null)
            {
                MessageBox.Show("Не создан граф А или В!", "Внимание!");
                return;
            }

            Graph crossingGraph = A.Crossing(B);
            string path = SetPath();

            WriteGraph(crossingGraph, path, false);
        }

        // Операция объединения
        private void UnionMenuItem_Click(object sender, EventArgs e)
        {
            if (A is null || B is null)
            {
                MessageBox.Show("Не создан граф А или В!", "Внимание!");
                return;
            }

            Graph unionGraph = A.Union(B);
            string path = SetPath();

            WriteGraph(unionGraph, path, false);
        }

        // Диаметр графа
        private void DiameterMainGraphMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (A is null || B is null)
                {
                    MessageBox.Show("Не создан граф А или В!", "Внимание!");
                    return;
                }
                InfoLabelA.Text = $"Диаметр графа А: {A.Length}";
                InfoLabelB.Text = $"Диаметр графа В: {B.Length}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        // Число вершин графа
        private void NumberOfVertexMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (A is null || B is null)
                {
                    MessageBox.Show("Не создан граф А или В!", "Внимание!");
                    return;
                }
                InfoLabelA.Text = $"Число вершин графа А: {A.NumberOfVertex}";
                InfoLabelB.Text = $"Число вершин графа В: {B.NumberOfVertex}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        // Число всех рёбер графа
        private void NumberOfEdgesMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (A is null || B is null)
                {
                    MessageBox.Show("Не создан граф А или В!", "Внимание!");
                    return;
                }    
                InfoLabelA.Text = $"Число рёбер графа А: {A.NumberOfEdges}";
                InfoLabelB.Text = $"Число рёбер графа В: {B.NumberOfEdges}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        // Количество рёбер каждой вершины графа
        private void EdgesOfVertexesMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OutputCountOfEdges(A, MainGraphStatsL);
                OutputCountOfEdges(B, SecondaryGraphStatsL);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        private void OutputCountOfEdges(Graph graph, Label graphLabel)
        {
            if (graph is null) throw new Exception("Не создан граф!");

            int count = 1;
            graphLabel.Text = "";
            foreach (int edges in graph.GetEdgesOfVertex())
                graphLabel.Text += $"[{count++}-{edges}]\n";
        }

        // Установка пути сохранения файла с результатом операций.
        private string SetPath()
        {
            using (var open = new SaveFileDialog())
            {
                string path = "";
                open.Filter = "Text file (.txt) | *.txt";

                if (open.ShowDialog() == DialogResult.OK)
                    path = open.FileName;

                return path;
            }
        }

        // Построение таблицы смежности из DataGridView
        private bool[,] BuildAdjecencyTable(DataGridView data)
        {
            int size = data.Rows.Count;
            bool[,] table = new bool[size, size];

            for (int i = 0; i < data.Rows.Count; i++)
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    string value = (string)data[i, j].Value;

                    if (string.IsNullOrEmpty(value))
                        throw new Exception("Не заполнена таблица смености графа!");

                    if (int.TryParse(value, out int cell))
                    {
                        if (cell > 0 && i == j)
                            throw new Exception("В графе не должно быть петель!");

                        if (cell == 1 && i != j)
                            table[i, j] = true;

                        if (cell > 1)
                            throw new Exception("Нужно вводить только 0 или 1!");
                    }
                    else
                        throw new Exception("Нужно вводить только 0 или 1!");
                }
            return table;
        }

        // Создание графа по списку смежности.
        private void CreateGraph(ref Graph graph, bool[,] adjTable)
        {
            if (CheckTable(adjTable))
                graph = new Graph(adjTable);
            else
                throw new Exception($"Заданный граф не является ориентированным!");
        }

        // Создание пустого или полного графа.
        private void CreateGraph(ref Graph graph, bool nullOrFull)
        {
            graph = new Graph(A.NumberOfVertex, nullOrFull);
        }

        // Проверка на неориентированный граф.
        private bool CheckTable(bool[,] table)
        {
            int size = table.GetLength(0);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    if (i != j && table[i, j] != table[j, i]) 
                        return false;
                }
            return true;
        }
        #endregion

        #region Вывод результатов операций над графами в файл
        // Записывает в файл результаты расчетов
        private void WriteGraph(Graph graph, string path, bool append)
        {
            int size = graph.AdjTable.GetLength(0);
            string title = $"Подграф с числом вершин: {size}";

            using (var writer = new StreamWriter(path, append))
            {
                writer.WriteLine(title);
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                        writer.Write($"{Convert.ToInt32(graph.AdjTable[i, j])} ");
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }

        // Записывает в файл все найденные правильные графы.
        private void WriteCorrectGraphs(Graph graph, string path, bool append)
        {
            using (var writer = new StreamWriter(path, append))
            {
                int countOfEdges = 2;
                List<bool[,]> subgraphs = graph.GetAllTheCorrectGraphs();

                if (graph.AdjTable.Equals(A.AdjTable))
                    writer.WriteLine("Правильные графы для графа А.");
                else
                    writer.WriteLine("Правильные графы для графа B.");

                for (int i = 0; i < subgraphs.Count; i++)
                {
                    int size = subgraphs[i].GetLength(0);
                    string title = $"Правильный граф с числом рёбер: {countOfEdges}";
                    countOfEdges++;

                    writer.WriteLine(title);
                    for (int j = 0; j < size; j++)
                    {
                        for (int k = 0; k < size; k++)
                            writer.Write($"{Convert.ToInt32(subgraphs[i][j, k])} ");
                        writer.WriteLine();
                    }
                    writer.WriteLine();
                }
                writer.WriteLine();
            }
        }
        #endregion

        #region Операции на подграфы
        // Найти подграф, который является дополнением до полного для графов.
        private void FindSubgraphMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = SetPath();
                Graph subgraphA = new Graph(A.SetSubgraph());
                Graph subgraphB = new Graph(B.SetSubgraph());
                WriteGraph(subgraphA, path, true);
                WriteGraph(subgraphB, path, true);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        // Найти все правильные графы для всех графов
        private void FindAllTheCorrectGraphsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string path = SetPath();
                WriteCorrectGraphs(A, path, true);
                WriteCorrectGraphs(B, path, true);
                Process.Start(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }

        // Найти число изолированных графов для всех графов.
        private void FindCountIsolatedGraphsMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                InfoLabelA.Text = $"Число изолированных подграфов в графе А: {A.GetIsolatedSubgraph()}";
                InfoLabelB.Text = $"Число изолированных подграфов в графе B: {B.GetIsolatedSubgraph()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!");
                return;
            }
        }
        #endregion

        private void Help_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Справка.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл справки не найден!", "Ошибка!");
            }
        }
    }
}