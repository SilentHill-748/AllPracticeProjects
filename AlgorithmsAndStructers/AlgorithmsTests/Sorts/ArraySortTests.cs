using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;

using Algorithms.Sorts;

namespace AlgorithmsTests
{
    public class ArraySortTests
    {
        private Random rnd;
        private readonly List<int> _items = new();
        private readonly List<int> _sorted = new();


        [SetUp]
        public void Setup()
        {
            rnd = new Random();

            _items.Clear();
            for (int i = 0; i < 10000; i++)
                _items.Add(rnd.Next(0, 1000));

            _sorted.Clear();
            _sorted.AddRange(_items.OrderBy(x => x).ToArray());
        }

        [Test]
        public void Bubble_Sort_Test()
        {
            ArraySort.BubbleSort(_items);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], _items[i]);
        }

        [Test]
        public void Insertion_Sort_Test()
        {
            ArraySort.InsertionSort(_items);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], _items[i]);
        }

        [Test]
        public void Coctail_Sort_Test()
        {
            ArraySort.CoctailSort(_items);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], _items[i]);
        }

        [Test]
        public void Shell_Sort_Test()
        {
            ArraySort.ShellSort(_items);

            CollectionAssert.AreEqual(_sorted, _items);
        }

        [Test]
        public void Should_Return_Sorted_Collection_From_TreeSort_Algorithm_Test()
        {
            TreeSort<int> treeSort = new TreeSort<int>();

            var actual = treeSort.Sort(_items);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], actual[i]);
        }

        [Test]
        public void BaseSort_Test()
        {
            _items.Sort();

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], _items[i]);
        }

        [Test]
        public void HoaraSort_Test()
        {
            var actual = ArraySort.QuickSort(_items);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], actual[i]);
        }

        [Test]
        public void HoaraSort_Test2()
        {
            int[] actual = _items.ToArray();
            ArraySort.QuickSort2(actual, 0, _items.Count - 1);

            for (int i = 0; i < _items.Count; i++)
                Assert.AreEqual(_sorted[i], actual[i]);
        }
    }
}