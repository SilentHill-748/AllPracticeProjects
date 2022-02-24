using System.Collections.Generic;

namespace WorkWithGraphs.Model
{
    internal class Vertex
    {
        public int Number { get; private set; }                 // Номер вершины.
        public bool IsVisited { get; set; }                     // Параметр для алгоритмов обхода графа.

        public List<Vertex> Neighbors { get; private set; }     // Число соседей вершины (с кем она связана)
        public int CountOfEdges { get => Neighbors.Count; }

        public Vertex(int number)
        {
            Neighbors = new List<Vertex>();
            IsVisited = false;
            Number = number;
        }

        public Vertex(int number, bool[,] adjTable) : this(number)
        {
            SetNeighbors(adjTable);
        }

        // Microsoft такое не одобряет, но студия закалопатила предупреждением.
        public override int GetHashCode() => Number.GetHashCode();

        // Для сравнения вершин по номеру.
        public override bool Equals(object obj)
        {
            Vertex vertex = obj as Vertex;

            if (vertex.Number.Equals(this.Number))
                return true;
            return false;
        }

        // Установка списков соседства для каждой вершины.
        private void SetNeighbors(bool [,] adjTable)
        {
            if (Neighbors is null)
                Neighbors = new List<Vertex>(); // Если список соседей не задан - создать его.

            int size = adjTable.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                // Если по таблице смежности у вершины Number стоит 1 напротив вершины i, то:
                if (adjTable[Number - 1, i] && i != Number - 1)
                    Neighbors.Add(new Vertex(i + 1)); // добавить в список соседей данную вершину.
            }
        }
    }
}