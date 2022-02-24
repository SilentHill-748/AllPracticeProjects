using System.Collections.Generic;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

using MyStructs = Structures.Collections;

namespace BenchmarkTests
{
    [MemoryDiagnoser]   // дать число потраченной памяти
    [RankColumn]        // Оценка для тестируемых методов
    public class ListsBenchmark
    {
        [Benchmark]
        public void DefaultListBenchmark()
        {
            List<int> defaultList = new();
            for (int i = 0; i < 10000; i++)
            {
                defaultList.Add(i);
            }
        }

        [Benchmark]
        public void MyListBenchmark()
        {
            MyStructs.List<int> myList = new();
            for (int i = 0; i < 10000; i++)
            {
                myList.Add(i);
            }
        }
    }
}
