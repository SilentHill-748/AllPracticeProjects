using System;
using NUnit.Framework;

using Structures.Collections;
using FluentAssertions;

namespace StructuresTests.CollectionsTests
{
    class LinkedListTests
    {
        private const string INDEX_OUT_OF_RANGE_EXC_MES = "Index was not in range of collection!";
        private const string NOT_SUPP_EXC_MES = "Collection is empty!";
        private const string COPYTO_INDEX_EXC_MES = "\"arrayIndex\" is not in range of array!";
        private const string ARG_EXC_MES = "Item doesn't exists!";
        private const string ARG_NULL_EXC_MES = "Array is null! (Parameter \'array\')";

        private LinkedList<int> list;

        [SetUp]
        public void Setup()
        {
            list = new LinkedList<int>();
            for (int i = 10; i > 0; i--)
                list.AddLast(i);
        }

        // Тестируется: Работа свойства Count.
        // Ожидается: Верное определение числа элементов в коллекции.
        [Test]
        public void Count_Property_Test()
        {
            LinkedList<int> list = new();
            list.AddFirst(5);
            for (int i = 1; i < 11; i++)
            {
                list.AddLast(i);
                if (i % 3 == 0)
                    list.RemoveLast();
            }
            Assert.AreEqual(8, list.Count);
        }

        // Тестируется: Добавления элемента в коллекцию.
        // Ожидается: Успешное добавление элементов и выброс исключения 
        // ArgumentException при попытке добавить элемент до и после 
        // элемента, которого нет в коллекции.
        [Test]
        public void Add_Item_To_LinkedList_Test()
        {
            LinkedList<int> list = new();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddAfter(1, 3);
            list.AddBefore(2, 4);

            int[] expected = { 1, 3, 4, 2 };
            Assert.AreEqual(4, list.Count);

            Throw<ArgumentException>(() => list.AddBefore(777, 5), ARG_EXC_MES);
            Throw<ArgumentException>(() => list.AddAfter(55, 3), ARG_EXC_MES);

            CollectionAssert.AreEquivalent(expected, list);
        }

        // Тестируется: Выброс исключения типа IndexOutOfRangeException при попытке
        // прочитать или перезаписать элементы, индексы которых вне диапазона.
        // Ожидается: Выброс исключений IndexOutOfRangeException.
        [Test]
        public void Indexator_Throw_IndexOutOfRangeException_Test()
        {
            int i = 0;
            Throw<IndexOutOfRangeException>(() => i = list[-1], INDEX_OUT_OF_RANGE_EXC_MES);
            Throw<IndexOutOfRangeException>(() => i = list[200], INDEX_OUT_OF_RANGE_EXC_MES);
            Throw<IndexOutOfRangeException>(() => list[-5] = 1, INDEX_OUT_OF_RANGE_EXC_MES);
            Throw<IndexOutOfRangeException>(() => list[748] = 2, INDEX_OUT_OF_RANGE_EXC_MES);
        }

        // Тестируется: Удаление элемента.
        // Ожидается: Успешное удаление.
        [Test]
        public void Remove_Element_Test()
        {
            int[] expected = { 10, 9, 8, 7, 6, 5, 4, 3, 1 };
            Assert.IsTrue(list.Remove(2));
            CollectionAssert.AreEquivalent(expected, list);
        }

        // Тестируется: Удаление элемента с начала.
        // Ожидается: Успешное удаление.
        [Test]
        public void RemoveFirst_Element_Test()
        {
            int[] expected = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            list.RemoveFirst();
            CollectionAssert.AreEquivalent(expected, list);
        }

        // Тестируется: Удаление элемента с конца.
        // Ожидается: Успешное удаление.
        [Test]
        public void RemoveLast_Element_Test()
        {
            int[] expected = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            list.RemoveLast();
            CollectionAssert.AreEquivalent(expected, list);
        }

        // Тестируется: Выброс исключения типа NotSupportedException при попытке
        // удаления элемента с начала в пустой коллекции.
        // Ожидается: Выброс исключения NotSupportedException.
        [Test]
        public void RemoveFirst_Throw_NotSupportedException_Test()
        {
            LinkedList<int> list = new();
            Throw<NotSupportedException>(() => list.RemoveFirst(), NOT_SUPP_EXC_MES);
        }

        // Тестируется: Выброс исключения типа NotSupportedException при попытке
        // удаления элемента с конца в пустой коллекции.
        // Ожидается: Выброс исключения NotSupportedException.
        [Test]
        public void RemoveLast_Throw_NotSupportedException_Test()
        {
            LinkedList<int> list = new();
            Throw<NotSupportedException>(() => list.RemoveLast(), NOT_SUPP_EXC_MES);
        }

        // Тестируется: Метод проверки наличия элемента в коллекции.
        // Ожидается: True для элементов, которые есть в коллекции и 
        // False для несуществующих элементов.
        [Test]
        public void Contains_Elements_Test()
        {
            for (int i = 10; i > 0; i--)
            {
                Assert.IsTrue(list.Contains(i));
                Assert.IsFalse(list.Contains(i*100));
            }
        }

        // Тестируется: Метод определения индекса элемента.
        // Ожидается: Успешное определение индексов.
        [Test]
        public void IndexOf_Element_Test()
        {
            for (int i = 0, j = 10; i < list.Count; i++, j--)
            {
                Assert.AreEqual(i, list.IndexOf(j));
            }
        }

        // Тестируется: Копирование всех элементов коллекции в массив.
        // Ожидается: Успешное копирование.
        [Test]
        public void CopyTo_Array_Test()
        {
            int[] expected = { 0, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            int[] actual = new int[12];
            list.CopyTo(actual, 2);
            Assert.AreEqual(expected, actual);
        }

        // Тестируется: Выброс исключений при копировании в методе CopyTo.
        // Ожидается: Исключения типа: IndexOutOfRangeException, ArgumentException
        // и ArgumentNullException.
        [Test]
        public void CopyTo_Throw_ArgumentOutOfRangeException_Test()
        {
            int[] target = new int[5];
            Throw<IndexOutOfRangeException>(() => list.CopyTo(target, 10), COPYTO_INDEX_EXC_MES);
            Throw<ArgumentException>(() => list.CopyTo(target, 0), "Collection is more than array!");
            Throw<ArgumentNullException>(() => list.CopyTo(null, 0), ARG_NULL_EXC_MES);
        }

        // Тестируется: Метод удаления всех элементов в коллекции.
        // Ожидается: Заполненная коллекция до очистки и пустая после.
        [Test]
        public void Clear_LinkedList_Test()
        {
            Assert.AreEqual(10, list.Count);

            list.Clear();
            Assert.AreEqual(0, list.Count);
        }

        // Тестируется: Клонирование коллекции в новый объект со всеми свойствами.
        // Ожидается: Успешное клонирование.
        [Test]
        public void Clone_LinkedList_Test()
        {
            object actual = list.Clone();
            Assert.IsTrue(actual is LinkedList<int>);
            Assert.AreEqual(list, actual);
            CollectionAssert.AreEquivalent(list, (LinkedList<int>)actual);
        }

        private void Throw<IException>(Action code, string message = "") where IException: Exception
        {
            if (message == "")
            {
                code.Should().Throw<IException>();
                return;
            }
            code.Should().Throw<IException>().WithMessage(message);
        }
    }
}