using System;
using NUnit.Framework;

using FluentAssertions;
using Structures.Collections;

namespace StructuresTests.CollectionsTests
{
    class QueueTests
    {
        private const string NOT_SUPP_EXC_MES = "Queue is empty!";

        Queue<int> queueOfNums;
        Queue<int> emptyQueue;

        [SetUp]
        public void Setup()
        {
            emptyQueue = new Queue<int>();
            queueOfNums = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                queueOfNums.Enqueue(i);
            }
        }

        // Тестируется: Добавление элементов в очередь.
        // Ожидается: Эквивалентное число элементов в очереди и массиве expected.
        // Эквиваленция самих элементов и их индексов в коллекциях.
        [Test]
        public void Enqueue_Elements_To_Queue_Test()
        {
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < 10; i++)
            {
                queueOfNums.Enqueue(i);
            }

            // Read queue to List.
            List<int> list = new();
            foreach (int item in queueOfNums)
                list.Add(item);

            for (int i = 0; i < expected.Length; i++)
                if (expected[i] != list[i])
                    Assert.Fail();
        }

        // Тестируется: Удаление элементов из очереди.
        // Ожидается: Удаление указанных элементов с начала очереди, подтверждение удаленных 
        // элементов и контрольная проверка численности элементов после удаления.
        [Test]
        public void Dequeue_Elements_From_Queue_Test()
        {
            int[] expected = { 4,5,6,7,8,9 };

            // Удаление и проверка удаленных элементов.
            for (int i = 0; i < 4; i++)
            {
                int removedItem = queueOfNums.Dequeue();
                Assert.AreEqual(i, removedItem);
            }
            CollectionAssert.AreEquivalent(expected, queueOfNums);
        }

        // Тестируется: Условие выбрасывания исключения в попытке удаления элемента в пустой очереди.
        // Ожидается: Выбрас исключения NotSupportedException с сообщением "Queue is empty!".
        [Test]
        public void Dequeue_Throw_NotSuppExc_Test()
        {
            Throw<NotSupportedException>(() => emptyQueue.Dequeue(), NOT_SUPP_EXC_MES);
        }

        // Тестируется: Проверка работы функции Peek() в процессе работы очереди.
        // Ожидается: Совпадение с ожидаемыми элементами, которые идут после удаления очередных.
        [Test]
        public void Peek_Element_From_Queue_Test()
        {
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(i, queueOfNums.Peek());
                queueOfNums.Dequeue();
            }
        }

        // Тестируется: Условие выброса исключения в случае чтения элемента без удаления в пустой очереди.
        // Ожидается: Выброс исключения NotSupportedException с сообщением "Queue is empty!"
        [Test]
        public void Peek_Throw_ArgOutOfRangeExc_Test()
        {
            Throw<NotSupportedException>(() => emptyQueue.Peek(),NOT_SUPP_EXC_MES);
        }

        // Тестируется: Проверка работы свойства Count в процессе работы очереди.
        // Ожидается: Совпадение значения свойства Count с ожидаемым.
        [Test]
        public void Count_Of_Elements_In_Queue_Test()
        {
            for (int i = 0, j = 10; i < 5; i++, j--)
            {
                Assert.AreEqual(j, queueOfNums.Count);
                queueOfNums.Dequeue();
            }
        }

        // Тестируется: Функция клонирования очереди в новый объект со всеми свойствами.
        // Ожидается: Успешное совпадение типа объекта, число элементов в объектах и 
        // равенство коллекций.
        [Test]
        public void Clone_Queue_To_NewObject_Test()
        {
            int[] expected = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            object actual = queueOfNums.Clone();

            // Проверка типов объектов и элементов внутри них.
            Assert.AreEqual(typeof(Queue<int>), actual.GetType());
            Assert.AreEqual(queueOfNums, actual);
            CollectionAssert.AreEquivalent(expected, (Queue<int>)actual);
        }

        // Проверяет, вызвал ли код делегата Action указанное исключение с заданным сообщением.
        private void Throw<TException>(Action code, string message) where TException : Exception
        {
            code.Should().Throw<TException>().WithMessage(message);
        }
    }
}