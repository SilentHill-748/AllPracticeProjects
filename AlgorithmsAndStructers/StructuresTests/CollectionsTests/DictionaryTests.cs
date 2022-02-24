using System;
using NUnit.Framework;

using FluentAssertions;
using Structures.Collections;

namespace StructuresTests.CollectionsTests
{
    class DictionaryTests
    {
        private Dictionary<int, string> dict;

        [SetUp]
        public void Setup()
        {
            dict = new Dictionary<int, string>();
        }

        // Тестируется: Добавление записи в словарь.
        // Ожидается: Корректное добавление. По ключу "1" должна быть запись "Test".
        [Test]
        public void Add_Record_To_Dictionary_Test()
        {
            object expected = "Test";
            dict.Add(1, "Test");

            object actual = dict[1];
            Assert.AreEqual(expected, actual);
        }
    }
}
