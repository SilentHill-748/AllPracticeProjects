using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace MyLibrary.Tests
{
    [TestClass()]
    public class CalculateTests
    {
        private static Calculate calc;

        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            calc = new Calculate();
        }

        [TestMethod()]
        public void Sum_15and30_45returned()
        {
            int x = 15, y = 30, excepted = 45;
            int actual = calc.Sum(x, y);

            Assert.AreEqual(excepted, actual, $"{x} + {y} has been {excepted}");
        }

        [TestMethod()]
        public void Multiply_7and12_84returned()
        {
            int x = 7, y = 12, excepted = 84;
            int actual = calc.Multiply(x, y);

            Assert.AreEqual(excepted, actual, $"{x} * {y} has been {excepted}");
        }
    }
}