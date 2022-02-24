using System;
using NUnit.Framework;

using Structures.Collections;
using FluentAssertions;

namespace StructuresTests.CollectionsTests
{
    public class ListTests
    {
        private const string NOT_SUPP_EXC_MES = "This collection is read-only!";
        private const string ARG_EXC_MES = "Array index is more than array length";
        private const string INDEX_OUT_OF_RANGE_EXC_MES = "Index is more than count of elements at list!";

        private List<int> testingList;
        private List<int> readOnlyList;

        private Action[] readOnlyActions;

        [SetUp]
        public void Setup()
        {
            testingList = new List<int>()
            { 9,8,7,6,5,4,3,2,1 };

            readOnlyList = new List<int>()
            { 9,8,7,6,5,4,3,2,1 };
            readOnlyList.IsReadOnly = true;

            readOnlyActions = InitActionsToReadOnlyTests();
        }

        // Тестируется: Метод добавления элемента в список.
        // Ожидается: Успешное добавление элемента.
        [Test]
        public void Add_Element_To_List_Test()
        {
            var expected = new List<int>(748);

            List<int> actual = new();
            actual.Add(748);

            CollectionAssert.AreEquivalent(expected, actual);
            Assert.AreEqual(expected[0], actual[0]);
        }

        // Тестируется: Удаление элемента по значению.
        // Ожидается: Успешное удаление.
        [Test]
        public void Remove_Element_From_List_Test()
        {
            var expected = new List<int>() 
            { 8, 7, 6, 4, 3, 2 };

            var actual = testingList;
            actual.Remove(5);
            actual.Remove(9);
            actual.Remove(1);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        // Тестируется: Удаление элемента по индексу.
        // Ожидается: Успешное удаление.
        [Test]
        public void RemoveAt_Element_From_List_Test()
        {
            var expected = new List<int>()
            { 9, 8, 7, 6, 5, 3, 2, 1 };

            var actual = testingList;
            actual.RemoveAt(5);

            CollectionAssert.AreEquivalent(expected, actual);
        }

        // Тестируется: Сортировка списка.
        // Ожидается: Успешная сортировка по возрастанию.
        [Test]
        public void Sort_List_Test()
        {
            var expected = new List<int>()
            { 1,2,3,4,5,6,7,8,9 };

            var actual = testingList;
            actual.Sort();

            CollectionAssert.AreEquivalent(expected, actual);
        }

        // Тестируется: Полная очистка списка.
        // Ожидается: Пустой список.
        [Test]
        public void Clear_List_Test()
        {
            var expected = 0;

            var actual = testingList;
            actual.Clear();

            Assert.AreEqual(expected, actual.Count);
        }

        // Тестируется: Определение на наличие элемента в списке. 
        // Ожидается: Успешное определение элементов, которые есть в списке 
        // и неудачное определение для несуществующих элементов.
        [Test]
        public void Contains_Element_At_List_Test()
        {
            var list = testingList;
            for (int i = 9; i > 0; i--)
            {
                Assert.IsTrue(list.Contains(i));
                Assert.IsFalse(list.Contains(i + 100));
            }
        }

        // Тестируется: Копирование списка в массив, копируя с указанного индекса.
        // Ожидается: Успешное копирование.
        [Test]
        public void CopyTo_Elements_To_Array_From_List_Test()
        {
            var expected = new int[]
            { 9,8,7,6,5,4,3,2,1 };

            var actual = new int[9];
            testingList.CopyTo(actual, 0);

            Assert.AreEqual(expected, actual);
        }

        // Тестируется: Определение индекса элемента по значению.
        // Ожидается: Успешное определение индекса.
        [Test]
        public void IndexOf_Element_At_List_Test()
        {
            var expected = 4;

            var actual = testingList.IndexOf(5);

            Assert.AreEqual(expected, actual);
        }

        // Тестируется: Вставка элемента после указанного индекса.
        // Ожидается: Успешная вставка.
        [Test]
        public void Insert_Element_To_List_Test()
        {
            var expected = new List<int>
            { 9,8,7,6,5,748,4,3,2,1 };

            var actual = testingList;
            actual.Insert(4, 748);

            Assert.AreEqual(expected, actual);
        }

        // Тестируется: Клонирование списка в новый объект.
        // Ожидается: Эквивалентность исходного и клонируемого объектов.
        [Test]
        public void Clone_List_Test()
        {
            var expected = new List<int>
            { 9,8,7,6,5,4,3,2,1 };

            var actual = (List<int>)testingList.Clone();

            Assert.AreEqual(expected, actual);
        }

        // Тестируется: Выброс исключения типа NotSupportException при попытке изменить
        // Read-only список.
        // Ожидается: Выбрасывание во всех случаях исключения NotSupportException
        // с сообщением NOT_SUPP_EXC_MES.
        [Test]
        public void ReadOnly_Property_Throws_NotSuppExc_Test()
        {
            for (int i = 0; i < 0; i++)
                Throw<NotSupportedException>(readOnlyActions[i], NOT_SUPP_EXC_MES);
        }

        // Тестируется: Выбрасывание исключения типа IndexOutOfRangeException в блоке set индексатора.
        // Ожидается: Выбрасывание исключения в случае с отрицательным значением и значением 
        // не лежащим в диапазоне индексов списка.
        [Test]
        public void Indexator_Setter_Throw_IndOutOfExc_Test()
        {
            Throw<IndexOutOfRangeException>(
                () => testingList[-8] = 5, INDEX_OUT_OF_RANGE_EXC_MES);
            Throw<IndexOutOfRangeException>(
                () => testingList[748888] = 5, INDEX_OUT_OF_RANGE_EXC_MES);
        }

        // Тестируется: Выбрасывание исключения типа ArgumentOutOfRangeException в блоке get индексатора.
        // Ожидается: Выбрасывание исключения при попытке прочитать значение элемента 
        // по отрицательному индексу и индексу, лежащем вне диапазона списка.
        [Test]
        public void Indexator_Getter_Throw_ArgOutOfRangeExc_Test()
        {
            int i = 0;
            Throw<ArgumentOutOfRangeException>(() => i = testingList[-8]);
            Throw<ArgumentOutOfRangeException>(() => i = testingList[78788]);
        }

        // Тестируется: Выбрасывание исключения типа ArgumentOutOfRangeException при попытке удалить
        // элемент, индекс которого не в диапазоне списка.
        // Ожидается: Выбрасывание исключения ArgumentOutOfRangeException.
        [Test]
        public void RemoveAt_Throw_ArgOutOfRange_Exc_Test()
        {
            Throw<ArgumentOutOfRangeException>(() => testingList.RemoveAt(66));
        }

        // Тестируется: Выбрасывание исключения типа ArgumentOutOfRangeException в методе Insert.
        // Ожидается: Выбрасывание исключения при попытке вставить элемент после
        // не существующего индекса.
        [Test]
        public void Insert_Throw_ArgOutOfExc_Test()
        {
            Throw<ArgumentOutOfRangeException>(() => testingList.Insert(100, 100));
        }

        // Тестируется: Выбрасывание исключения типа ArgumentException в методе CopyTo.
        // Ожидается: Выбрасывание исключения при попытке начать копирование с индекса, который
        // лежит вне диапазона массива, в который нудно скопировать элементы.
        [Test]
        public void CopyTo_Throw_ArgExc_Test()
        {
            int[] array = new int[20];
            Throw<ArgumentException>(() => testingList.CopyTo(array, 50), ARG_EXC_MES);
        }

        // Тестируется: Выбрасывание исключения типа ArgumentNullException в методе CopyTo.
        // Ожидается: Выброс исключения при попытке передать вместо массива null-значение.
        [Test]
        public void CopyTo_Throw_ArgNullExc_Test()
        {
            Throw<ArgumentNullException>(() => testingList.CopyTo(null, 11));
        }

        // Проверяет, вызвал ли код делегата Action указанное исключение с заданным сообщением.
        private void Throw<TException>(Action code, string message = "") where TException : Exception
        {
            if (message == "")
            {
                code.Should().Throw<TException>();
                return;
            }
            code.Should().Throw<TException>().WithMessage(message);
        }

        // Действия, которые будут вызывать NotSupportException.
        private Action[] InitActionsToReadOnlyTests()
        {
            return new Action[]
            {
                () => readOnlyList[4] = 5,
                () => readOnlyList.Add(22),
                () => readOnlyList.Remove(1),
                () => readOnlyList.RemoveAt(3),
                () => readOnlyList.Sort(),
                () => readOnlyList.Clear(),
                () => readOnlyList.Insert(1, 1)
            };
        }
    }
}