using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionalLibrary;
using System;

namespace FractionalNumberTests
{
    [TestClass]
    public class FractionalNumberTests
    {
        private FractionalNumber first;
        private FractionalNumber second;

        [TestInitialize]
        public void Init()
        {
            first = new FractionalNumber(12, 45);   // 12/45
            second = new FractionalNumber(78, 21);  // 78/21
        }

        [TestMethod]  // Тест суммы.
        public void InitNumberTest()
        {
            string expected = "7/8";
            var actual = new FractionalNumber(7, 8);

            Assert.AreEqual(expected, actual.ToString());
        }

        // Проверка на исключение в случае нулевого числителя при инициализации.
        [ExpectedException(typeof(Exception))]
        [TestMethod] 
        public void InitNumberWithZeroNumeratorTest()
        {
            var actual = new FractionalNumber(0, 25);
        }

        [TestMethod]  // Тест суммы.
        public void SumNumbersTest() 
        {
            string expected = "3762/945";
            var actual = first + second;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]  // Тест разности.
        public void DifferenceNumbersTest()
        {
            string expected = "-3258/945";
            var actual = first - second;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]  // Тест умножения.
        public void MultiplyNumbersTest()
        {
            string expected = "936/945";
            var actual = first * second;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]  // Тест деления.
        public void DivisionNumbersTest()
        {
            string expected = "252/3510";
            var actual = first / second;

            Assert.AreEqual(expected, actual.ToString());
        }

        [TestMethod]  // Тест сокращения.
        public void ReductionNumbersTest()
        {
            string expected = "26/7";
            second.Reduction();

            Assert.AreEqual(expected, second.ToString());
        }

        [TestMethod]  // Тест возведения
        public void ExponentiationNumbersTest()
        {
            string expected = "1728/91125";
            var actual = first.Exponentiation(3);

            Assert.AreEqual(expected, actual.ToString());
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod]  // Тест исключения, при вводе отрицательной степени.
        public void ExponentiationNotNaturalNumbersTest()
        {
            var actual = first.Exponentiation(-3);
        }

        [TestMethod]  // Тест сравнения: первое число больше второго.
        public void FirstMoreSecondTest()
        {
            var expected = false;
            var actual = first > second;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]   // Тест сравнения: первое число меньше второго.
        public void FirstLessSecondTest()
        {
            var expected = true;
            var actual = first < second;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]   // Тест сравнения: первое число больше или равно второму.
        public void FirstMoreOrEqualSecondTest()
        {
            var expected = false;
            var actual = first >= second;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]   // Тест сравнения: первое число меньше или равно второму.
        public void FirstLessOrEqualSecondTest()
        {
            var expected = true;
            var actual = first <= second;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]   // Тест сравнения: первое число равно второму.
        public void FirstEqualSecondTest()
        {
            var expected = false;
            var actual = first == second;

            Assert.AreEqual(expected, actual);
        }


        [TestMethod]   // Тест сравнения: первое число не равно второму.
        public void FirstNotEqualSecondTest()
        {
            var expected = true;
            var actual = first != second;

            Assert.AreEqual(expected, actual);
        }
    }
}
