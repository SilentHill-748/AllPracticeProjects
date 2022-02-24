using System.Collections;

using BenchmarkDotNet.Attributes;

using MyStructs = Structures.Collections;

namespace BenchmarkTests
{
    [MemoryDiagnoser]
    [RankColumn]
    public class ArrayListsBenchmark
    {
        [Benchmark]
        public void DefaultArrayListBenchmark()
        {
            ArrayList defaultList = new();
            for (int i = 0; i < 10000; i++)
            {
                defaultList.Add(i);
            }
        }

        [Benchmark]
        public void MyArrayListBenchmark()
        {
            MyStructs.ArrayList<int> myList = new();
            for (int i = 0; i < 10000; i++)
            {
                myList.Add(i);
            }
        }
    }
}
