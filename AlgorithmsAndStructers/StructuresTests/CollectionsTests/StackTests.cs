using System;
using NUnit.Framework;

using FluentAssertions;
using Structures.Collections;

namespace StructuresTests.CollectionsTests
{
    class StackTests
    {
        private const string NOT_SUPP_EXC_MESSAGE = "Stack is empty!";

        private Stack<int> stackOfNums;
        private Stack<int> emptyStack;

        [SetUp]
        public void Setup()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            stackOfNums = new Stack<int>(array);
            emptyStack = new Stack<int>();
        }

        // Тестируется: Инициализация стека с заданным перечислителя 
        // и в следствии проверка работы метода Push().
        // Ожидается: Успешное заполнение стека элементами перечислителя.
        [Test]
        public void Stack_Initialize_With_Collection_Test()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            Stack<int> actual = new(array);

            Assert.AreEqual(expected.Length, actual.Count);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        // Тестируется: Метод чтения элемента с его удалением из стека.
        // Ожидается: Успешное чтение элементов и удаление.
        [Test]
        public void Pop_Items_From_Stack_Test()
        {
            int[] expectedPopedItems = { 0, 9, 8, 7, 6 };
            int[] actualPopedItems = new int[5];
            for (int i = 0; i < 5; i++)
            {
                actualPopedItems[i] = stackOfNums.Pop();
            }
            CollectionAssert.AreEquivalent(expectedPopedItems, actualPopedItems);
            
            // Проверка удаления единственного айтема.
            Stack<int> stack = new();
            stack.Push(1);
            int popedItem = stack.Pop();

            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(1, popedItem);
        }

        // Тестируется: Выброс исключения типа NotSupportedException в случае 
        // чтения с удалением из пустого стека.
        // Ожидается: Исключение NotSupportedException.
        [Test]
        public void Pop_Throw_NotSupp_Exc_Test()
        {
            Throw<NotSupportedException>(() => emptyStack.Pop(), NOT_SUPP_EXC_MESSAGE);
        }

        // Тестируется: Чтение верхнего элемента без удаления.
        // Ожидается: Успешное чтение.
        [Test]
        public void Peek_Items_From_Stack_Test()
        {
            Assert.AreEqual(0, stackOfNums.Peek());
            Assert.AreEqual(10, stackOfNums.Count);
        }

        // Тестируется: Выброс исключения типа NotSupportedException в случае
        // чтения верхнего элемента в пустом стеке.
        // Ожидается: Исключение NotSupportedException.
        [Test]
        public void Peek_Throw_NotSuppExc_Test()
        {
            Throw<NotSupportedException>(() => emptyStack.Peek(), NOT_SUPP_EXC_MESSAGE);
        }

        // Тестируется: Клонирование стека в новый объект.
        // Ожидается: Успешное клонирование.
        [Test]
        public void Clone_Stack_To_New_Object_Test()
        {
            object actual = stackOfNums.Clone();

            Assert.IsTrue(actual is Stack<int>);
            Assert.AreEqual(stackOfNums, actual);
            CollectionAssert.AreEquivalent(stackOfNums, (Stack<int>)actual);
        }

        // Тестируется: Очистка стека.
        // Ожидается: Успешное определение заполненного и пустого стека.
        [Test]
        public void Clear_Stack_Test()
        {
            Assert.AreEqual(10, stackOfNums.Count);
            stackOfNums.Clear();
            Assert.AreEqual(0, stackOfNums.Count);
        }

        // Проверяет, вызвал ли код делегата Action указанное исключение с заданным сообщением.
        private void Throw<TException>(Action code, string message = "") where TException: Exception
        {
            if (message == "")
            {
                code.Should().Throw<TException>();
                return;
            }
            code.Should().Throw<TException>().WithMessage(message);
        }
    }
}
