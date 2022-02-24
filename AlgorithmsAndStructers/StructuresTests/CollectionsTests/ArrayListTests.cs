using System;
using NUnit.Framework;

using FluentAssertions;
using Structures.Collections;

namespace StructuresTests.CollectionsTests
{
    class ArrayListTests
    {
        private const string ARG_OUT_OF_EXC_MES = "Index was out of range! (Parameter \'index\')";
        private const string ARG_EXC_MES = "Array index is more than array length!";
        private const string NOT_SUPP_EXC_MES = "Collection is read-only!";

        private ArrayList<int?> arrayList;
        private Random rnd;

        // Заполнение тестируемого объекта 10 значениями от 10 до 1.
        [SetUp]
        public void Setup()
        {
            arrayList = new ArrayList<int?>();
            for (int i = 10; i > 0; i--)
                arrayList.Add(i);
            rnd = new Random();
        }

        // Тестируется: Работа метода Add.
        // Ожидается: Добавление числа 1 в list и свойство Count равно 1.
        [Test]
        public void Add_Element_To_ArrayList_Test()
        {
            ArrayList<int> list = new() { 1 };
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(1, list[0]);
        }

        // Тестируется: Работа метода Remove.
        // Ожидается: Удаление элементов 2, 4 и 6; свойства Count равно ожидаемому (7).
        [Test]
        public void Remove_Element_From_ArrayList_Test()
        {
            ArrayList<int> expected = new() { 10, 9, 8, 7, 5, 3, 1 };
            arrayList.Remove(2);
            arrayList.Remove(4);
            arrayList.Remove(6);
            CollectionAssert.AreEquivalent(expected, arrayList);
            Assert.AreEqual(expected.Count, arrayList.Count);
        }

        // Тестируется: Работа метода RemoveAt.
        // Ожидается: Удаление элементов с индексами 4, 6 и 8 (они же 6, 4, 2);
        // свойство Count равно ожидаемому (7).
        [Test]
        public void RemoveAt_Element_From_ArrayList_Test()
        {
            ArrayList<int> expected = new() { 10, 9, 8, 7, 5, 3, 1 };
            arrayList.RemoveAt(8);
            arrayList.RemoveAt(6);
            arrayList.RemoveAt(4);
            CollectionAssert.AreEquivalent(expected, arrayList);
            Assert.AreEqual(expected.Count, arrayList.Count);
        }

        // Тестируется: Выброс исключения при попытке удаления по некорректному индексу.
        // Ожидается: Выбрасывание исключения ArgumentOutOfRangeException.
        [Test]
        public void RemoveAt_Throw_ArgumentOutOfRangeException_Test()
        {
            Throw<ArgumentOutOfRangeException>(
                () => arrayList.RemoveAt(-5), ARG_OUT_OF_EXC_MES);
        }

        [Test]
        public void Insert_Element_To_ArrayList_Test()
        {
            ArrayList<int> expected = new()
            { 10, 9, 8, 7, 748, 6, 5, 4, 3, 2, 1 };
            arrayList.Insert(3, 748);
            CollectionAssert.AreEquivalent(expected, arrayList);
        }

        // Тестируется: Работа метода Clear.
        // Ожидается: Пустая коллекция arrayList со значением свойства Count = 0.
        [Test]
        public void Clear_All_Collection_From_ArrayList_Test()
        {
            Assert.AreEqual(10, arrayList.Count);

            arrayList.Clear();
            Assert.AreEqual(0, arrayList.Count);
        }

        // Тестируется: Клонирование объекта.
        // Ожидается: Объект, эквивалентный клонируемому.
        [Test]
        public void Clone_ArrayList_To_New_Object_Test()
        {
            var expected = new ArrayList<int?>()
            { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            object actual = arrayList.Clone();

            // Проверка типа клонируемого объекта и его содержимого с ожидаемым объектом.
            Assert.AreEqual(typeof(ArrayList<int?>), actual.GetType());
            CollectionAssert.AreEqual(expected, (ArrayList<int?>)actual);
            CollectionAssert.AreEquivalent(expected, (ArrayList<int?>)actual);
        }

        // Тестируется: Метод Contains.
        // Ожидается: True для элементов коллекции и False для элементов, не лежащих в коллекции.
        [Test]
        public void Contains_Elements_In_ArrayList_Test()
        {
            for (int i = 10; i > 0; i--)
            {
                Assert.IsTrue(arrayList.Contains(i));
                Assert.IsFalse(arrayList.Contains(rnd.Next(-100, 1)));
            }
        }

        // Тестируется: Копирование объекта в массив.
        // Ожидается: Сумма элементов и эквиваленция каждого элемента в массиве, в который
        // скопирована коллекция arrayList.
        [Test]
        public void CopyTo_Array_From_ArrayList_Test()
        {
            int?[] test1 = new int?[12];
            int?[] test2 = new int?[10];
            int?[] test3 = new int?[11];
            int?[] test4 = new int?[16];

            arrayList.CopyTo(test1, 2);
            arrayList.CopyTo(test2, 0);
            arrayList.CopyTo(test3, 0);
            arrayList.CopyTo(test4, 5);

            CollectionAssert.AreEquivalent(
                new int?[] { null, null, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, test1);
            CollectionAssert.AreEquivalent(
                new int?[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }, test2);
            CollectionAssert.AreEquivalent(
                new int?[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, null }, test3);
            CollectionAssert.AreEquivalent(
                new int?[] { null, null, null, null, null, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, null }, test4);
        }

        // Тестируется: Выброс исключения в случае передачи null-типа в параметры.
        // Ожидается: Выброс исключения ArgumentNullException.
        [Test]
        public void CopyTo_Throw_ArgNullExc_Test()
        {
            Throw<ArgumentNullException>(() => arrayList.CopyTo(null, 5));
        }

        // Тестируется: Выброс исключения в случае некорректного значения индекса массива.
        // Ожидается: Выброс исключения ArgumentException с сообщением
        // "Array index is more than array length!"
        [Test]
        public void CopyTo_Throw_ArgExc_Test()
        {
            int?[] array = new int?[10];
            Throw<ArgumentException>(() => arrayList.CopyTo(array, 20), ARG_EXC_MES);
        }

        // Тестируется: Функция определения индекса элемента.
        // Ожидается: Корректные номер индексов для каждого элемента и -1 для элементов вне коллекции arrayList.
        [Test]
        public void IndexOf_Elements_Of_ArrayList_Test()
        {
            for (int i = 0, j = 10; i < arrayList.Count; i++, j--)
            {
                int randNum = rnd.Next(-1000, 0);
                Assert.AreEqual(i, arrayList.IndexOf(j));
                Assert.AreEqual(-1, arrayList.IndexOf(randNum));
            }
        }

        // Тестируется: Работа свойства IsReadOnly.
        // Ожидается: Выбрасывание исключений типа NotSupportedException в тестируемых методах объекта ArrayList.
        [Test]
        public void ArrayList_Is_Read_Only_Test()
        {
            arrayList.IsReadOnly = true;

            Action[] testOperations = InitActionsToReadOnlyTests();

            for (int i = 0; i < testOperations.Length; i++)
                Throw<NotSupportedException>(testOperations[i], NOT_SUPP_EXC_MES);
        }

        // Тестируется: Выброс исключения при записи null-значения по индексу.
        // Ожидается: Выброс исключения ArgumentNullException.
        [Test]
        public void Indexator_Throw_ArgNullExc_Test()
        {
            Throw<ArgumentNullException>(() => arrayList[1] = null);
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

        private Action[] InitActionsToReadOnlyTests()
        {
            return new Action[]
            {
                () => arrayList[3] = 5,
                () => arrayList.Add(1),
                () => arrayList.Remove(1),
                () => arrayList.RemoveAt(3),
                () => arrayList.Insert(4, 4),
                () => arrayList.Clear()
            };
        }
    }
}