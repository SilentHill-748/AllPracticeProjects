using System.Collections.Generic;

namespace WorkWithGraphs.Model
{
    internal class Graph
    {
        private List<Vertex> adjList;                       // Список смежности графа. С ним и будем работать.

        public bool[,] AdjTable { get; private set; }       // Таблица смежности графа. 
        public int NumberOfVertex { get; private set; }     // Число вершин в графе.
        public int NumberOfEdges { get; private set; }      // Число рёбер графа.

        public int Length { get; private set; } = 0;        // Длина самого длинного нецикличного маршрута.
        public bool IsFull { get; private set; } = false;   // Указывает, является ли граф полным.

        /// <summary>
        /// Инициализирует новый пустой или полный граф с заданным числом вершин.
        /// </summary>
        /// <param name="vertexes">Число вершин графа.</param>
        /// <param name="nullOrFull">Указывает, каким будет граф. True - полным или False - пустым.</param>
        public Graph(int vertexes, bool nullOrFull)
        {
            CreateNullOrFullGraph(vertexes, nullOrFull);
            NumberOfVertex = vertexes;
            NumberOfEdges = CountEdges();

            FindDiameter();
            ResetVisiting(adjList);
        }

        /// <summary>
        /// Инициализирует новый граф из заданной таблицы смежности.
        /// </summary>
        /// <param name="adjacencyTable">Таблица смежности заданного графа.</param>
        public Graph(bool[,] adjacencyTable)
        {
            AdjTable = adjacencyTable;
            NumberOfVertex = AdjTable.GetLength(0);
            NumberOfEdges = CountEdges();

            SetAdjacencyList();
            FullGraph();
            FindDiameter();
            ResetVisiting(adjList);
        }

        // Число рёбер из каждой вершины.
        public int[] GetEdgesOfVertex()
        {
            int[] edges = new int[adjList.Count];

            foreach (Vertex vertex in adjList)
                edges[vertex.Number - 1] = vertex.Neighbors.Count;

            return edges;
        }

        // Операция пересечения графа.
        public Graph Crossing(Graph inner)
        {
            int size = Copmpare(inner, out bool[,] newGraph);
            bool[,] graph = new bool[size, size];

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    graph[i, j] = AdjTable[i, j] & inner.AdjTable[i, j];
                }

            return new Graph(graph);
        }

        // Операция объединения графов.
        public Graph Union(Graph inner)
        {
            int size = Copmpare(inner, out bool[,] newGraph);

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    newGraph[i, j] = AdjTable[i, j] | inner.AdjTable[i, j];
                }

            return new Graph(newGraph);
        }

        // Строит подграф - дополнение текущего графа до полного.
        public bool[,] SetSubgraph()
        {
            if (IsFull) return this.AdjTable;

            int size = NumberOfVertex;
            bool[,] subgraph = new bool[size, size];

            for (int i = 0; i < size; i++)
                for (int k = 0; k < size; k++)
                {
                    if (!(AdjTable[i, k]) && i != k)
                        subgraph[i, k] = true;
                }

            return subgraph;
        }

        // Нахождение изолированных подграфов в графе.
        public int GetIsolatedSubgraph()
        {
            int countSubgraph = 0;

            for (int i = 0; i < adjList.Count; i++)
            {
                Queue<Vertex> queue = new Queue<Vertex>();
                Vertex current = adjList[i];

                if (current.IsVisited) continue;

                if (current.CountOfEdges == 0)
                {
                    countSubgraph++;
                    continue;
                }
                else
                {
                    countSubgraph++;
                    current.IsVisited = true;
                    queue.Enqueue(current);
                    while (queue.Count > 0)
                    {
                        Vertex vertex = queue.Dequeue();
                        foreach (Vertex n in vertex.Neighbors)
                        {
                            Vertex neighob = GetFromList(n);
                            if (!neighob.IsVisited)
                            {
                                queue.Enqueue(neighob);
                                neighob.IsVisited = true;
                            }
                        }
                    }
                }
            }

            ResetVisiting(adjList);     // Снять метки посещений с вершин для других алгоритмов.
            return countSubgraph == 1 ? 0 : countSubgraph; 
        }

        // Вернет список таблиц смежности найденных правильных графов.
        public List<bool[,]> GetAllTheCorrectGraphs()
        {
            List<bool[,]> adjTables = new List<bool[,]>();      // Создаю коллекцию найденных правильных графов.
            int targetEdges = 2;                                // Целевое число ребёр в правильном графе. 2 - минимальный возможный.
            
            while (targetEdges < NumberOfVertex - 1)
            {
                bool[,] table = FindCorrectGraph(targetEdges);

                if (CheckTable(targetEdges, table))
                    adjTables.Add(table);               // В конце добавим таблицу в коллекцию.

                targetEdges++;
            }

            return adjTables;
        }

        // Ищет правильный граф с указанным числом связей его вершин.
        private bool[,] FindCorrectGraph(int targetEdges)
        {
            List<Vertex> tempAdjList = new List<Vertex>();              // Список, куда добавляются связанные вершины.
            Graph nullGraph = new Graph(NumberOfVertex, false);         // Пустой граф без связей.

            while (nullGraph.adjList.Count > 0)                         // Циклом проходим по каждой вершине, удаляя ее из мписка.
            {
                Vertex vert = nullGraph.adjList[0];                     // Запомнить очередную вершину.
                nullGraph.adjList.RemoveAt(0);

                if (vert.Neighbors.Count == targetEdges)                // Если на очередной вершине уже есть заданное число ребёр, то скипнуть ход.
                {
                    tempAdjList.Add(vert);
                    continue;
                }

                SetupEdges(ref vert, nullGraph.adjList, targetEdges);   // Построим для этой вершины все связи до нужного количества.
                tempAdjList.Add(vert);
            }

            return BuildAdjacencyTable(tempAdjList);                    // Построим таблицу из списка смежности.
        }

        // Связывает вершины, пока число связей не будет равно нужному числу.
        private void SetupEdges(ref Vertex vertex, List<Vertex> list, int targetEdges)
        {
            if (list.Count == 0) return;

            int min = 0;
            while (vertex.CountOfEdges < targetEdges)    // Пока у вершины не станет нужное число рёбер:
            {
                for (int j = 0; j < list.Count; j++)     // - Ищем вершины для связи
                {
                    if (vertex.CountOfEdges < targetEdges)
                    {
                        if (list[j].CountOfEdges == min)
                        {
                            vertex.Neighbors.Add(list[j]);     // Связать 2 вершины 1 связью.
                            list[j].Neighbors.Add(vertex);
                        }
                    }
                    else
                        return;
                }
                min++;
            }
        }

        private int Copmpare(Graph graph, out bool[,] adjTable)
        {
            if (graph.NumberOfVertex >= NumberOfVertex)
            {
                adjTable = graph.AdjTable;
                return NumberOfVertex;
            }
            else
            {
                adjTable = this.AdjTable;
                return graph.NumberOfVertex;
            }
        }

        // Поиск максимального диаметра графа из каждой вершины в последнюю. 
        private void FindDiameter()
        {
            int maxLen = 0;
            foreach (Vertex current in adjList)
            {
                // Найдем длину маршрута от текущей вершины до последней.
                int len = 0;
                CountLength(current, adjList[NumberOfVertex - 1], ref len);
                if (len > maxLen)
                    maxLen = len; // Сохраним наибольший маршрут.
                ResetVisiting(adjList);
            }
            Length = maxLen;
        }

        // Диаметр графа по алгоритму обхода в глубину.
        private bool CountLength(Vertex vertex, Vertex target, ref int len)
        {
            if (vertex.Equals(target)) return true;
            if (vertex.IsVisited) return false;

            vertex.IsVisited = true;
            foreach (Vertex neighbor in vertex.Neighbors)
            {
                Vertex v = GetFromList(neighbor);
                if (!v.IsVisited)
                {
                    len++;
                    bool isFinded = CountLength(v, target, ref len);
                    if (isFinded)
                        return true;
                    else
                        len--;
                }
            }
            return false;
        }

        private Vertex GetFromList(Vertex neighbor)
        {
            return adjList[neighbor.Number - 1];
        }

        // Найти число рёбер графа.
        private int CountEdges()
        {
            int count = 0;
            for (int i = 0; i < NumberOfVertex; i++)
                for (int j = i + 1; j < NumberOfVertex; j++)
                {
                    if (AdjTable[i, j]) count++;
                }
            return count;
        }

        // Построит список смежности.
        private void SetAdjacencyList()
        {
            if (adjList is null)
                adjList = new List<Vertex>();

            int size = AdjTable.GetLength(0);
            for (int i = 0; i < size; i++)
                adjList.Add(new Vertex(i + 1, AdjTable));
        }

        // Проверяет, является ли граф полным.
        private void FullGraph()
        {
            for (int i = 0; i < NumberOfVertex; i++)
            {
                if (adjList[i].CountOfEdges < NumberOfVertex - 1)
                {
                    IsFull = false;
                    return;
                }
            }
            IsFull = true;
        }

        // Сбросить маркеры с вершин.
        private void ResetVisiting(List<Vertex> list)
        {
            foreach (var vertex in list)
                vertex.IsVisited = false;
        }

        // Строит таблицу смежности по списку смежности.
        private bool[,] BuildAdjacencyTable(List<Vertex> list)
        {
            int size = list.Count;
            bool[,] table = new bool[size, size];

            for (int i = 0; i < size; i++)
                foreach (Vertex vert in list[i]?.Neighbors)
                {
                    table[i, vert.Number - 1] = true;
                }
            
            return table;
        }

        private bool CheckTable(int targetEdges, bool[,] table)
        {
            int count = 0;
            int size = table.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (table[i, j])
                        count++;
                }

                if (count != targetEdges) return false;
                count = 0;
            }
            return true;
        }

        private void CreateNullOrFullGraph(int vertexes, bool nullOrFull)
        {
            IsFull = nullOrFull;

            AdjTable = new bool[vertexes, vertexes];
            for (int i = 0; i < vertexes; i++)
                for (int j = 0; j < vertexes; j++)
                {
                    if (i == j) AdjTable[i, j] = false;
                    AdjTable[i, j] = nullOrFull;
                }

            SetAdjacencyList();
        }
    }
}