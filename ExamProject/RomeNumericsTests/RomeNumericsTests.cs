using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ExamProject;

namespace RomeNumericsTests
{
    public class RomeNumericsTests
    {
        RomeNumerics[] romeNumbers;
        string[] stringRomeNums;
        int[] intNums;

        [SetUp]
        public void Setup()
        {
            romeNumbers = new RomeNumerics[]
            {
                new RomeNumerics(0),
                new RomeNumerics(1),
                new RomeNumerics(43),
                new RomeNumerics(742),
                new RomeNumerics(1000),
                new RomeNumerics(500),
                new RomeNumerics(1050)
            };

            stringRomeNums = new string[]
            {
                "XXX",
                "I",
                "MDCC",
                "CLVII",
                "MMDCCCLXXX",
                "XL",
                "V"
            };

            intNums = new int[]
            {
                5, 2, 1, 66, 58, 746, 10254, 5, 60, 1700
            };
        }

        [Test]
        public void Parse_IntNumber_To_RomeNumber_Test()
        {
            Assert.AreEqual("", romeNumbers[0].Value);
            Assert.AreEqual("I", romeNumbers[1].Value);
            Assert.AreEqual("XXXXIII", romeNumbers[2].Value);
            Assert.AreEqual("DCCXXXXII", romeNumbers[3].Value);
            Assert.AreEqual("M", romeNumbers[4].Value);
            Assert.AreEqual("D", romeNumbers[5].Value);
            Assert.AreEqual("ML", romeNumbers[6].Value);
        }

        [Test]
        public void Attempt_Parse_Negative_Numbers_Test()
        {
            string expected =
                "Операция преобразования не работает с отрицательными числами!";
            try
            {
                RomeNumerics num = new RomeNumerics(-452);
            }
            catch (InvalidCastException e)
            {
                Assert.AreEqual(expected, e.Message);
            }
        }

        [Test]
        public void Format_From_Rome_To_IntNum_Test()
        {
            Assert.AreEqual(0, romeNumbers[0].IntValue);
            Assert.AreEqual(1, romeNumbers[1].IntValue);
            Assert.AreEqual(43, romeNumbers[2].IntValue);
            Assert.AreEqual(742, romeNumbers[3].IntValue);
            Assert.AreEqual(1000, romeNumbers[4].IntValue);
            Assert.AreEqual(500, romeNumbers[5].IntValue);
            Assert.AreEqual(1050, romeNumbers[6].IntValue);
        }

        [Test]
        public void Sum_Two_RomeNums_Test()
        {
            RomeNumerics expected = new RomeNumerics(1742);

            // 1000+742
            RomeNumerics actual = romeNumbers[4] + romeNumbers[3];

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        public void Deff_Two_RomeNums_Test()
        {
            RomeNumerics expected = new RomeNumerics(258);

            // 1000-742
            RomeNumerics actual = romeNumbers[4] - romeNumbers[3];

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        public void Multiply_Two_RomeNums_Test()
        {
            RomeNumerics expected = new RomeNumerics(1850);
            var first = new RomeNumerics(25);
            var second = new RomeNumerics(74);

            // 25*74=1850
            RomeNumerics actual = first * second;

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        public void Divide_Two_RomeNums_Test()
        {
            RomeNumerics expected = new RomeNumerics(3);
            var first = new RomeNumerics(75);
            var second = new RomeNumerics(25);

            // 75/25
            RomeNumerics actual = first / second;

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        public void Divide_With_Rest_Two_RomeNums_Test()
        {
            RomeNumerics expected = new RomeNumerics(400);
            var first = new RomeNumerics(2000);
            var second = new RomeNumerics(800);

            // 5 % 2 = 1
            RomeNumerics actual = first % second;

            Assert.AreEqual(expected.Value, actual.Value);
        }

        [Test]
        public void First_RomeNum_More_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) > new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) > new RomeNumerics(1);
            bool actual = !test1 && test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void First_RomeNum_Less_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) < new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) < new RomeNumerics(1);
            bool actual = !test1 && !test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void First_RomeNum_MoreOrEqual_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) >= new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) >= new RomeNumerics(1);
            bool actual = test1 && test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void First_RomeNum_LessOrEqual_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) <= new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) <= new RomeNumerics(1);
            bool actual = test1 && !test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void First_RomeNum_Equal_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) == new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) == new RomeNumerics(1);
            bool actual = test1 && !test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void First_RomeNum_NotEqual_Than_Second_Test()
        {
            bool test1 = new RomeNumerics(3) != new RomeNumerics(3);
            bool test2 = new RomeNumerics(3) != new RomeNumerics(1);
            bool actual = !test1 && test2;

            Assert.IsTrue(actual);
        }

        [Test]
        public void Sort_Array_Of_RomeNumbers_Test()
        {
            var nums = InitArray(stringRomeNums);
            Sort(nums);

            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] > nums[i + 1])
                    Assert.Fail();
            }
        }

        [Test]
        public void Find_Exists_Nums_In_RomeArray_And_intArray_Test()
        {
            string expectedRome = "I V XL MDCC ";
            string expectedInt = "1 5 60 1700 ";

            var findedNums = FindExistsInRomeNumsAndIntNums(intNums, stringRomeNums);
            string actualRome = "";
            string actualInt = "";

            for (int i = 0; i < findedNums.Length; i++)
            {
                actualInt += $"{findedNums[i].IntValue} ";
                actualRome += $"{findedNums[i].Value} ";
            }

            Assert.AreEqual(expectedRome, actualRome);
            Assert.AreEqual(expectedInt, actualInt);
        }

        private RomeNumerics[] FindExistsInRomeNumsAndIntNums(int[] intNums, string[] romeNums)
        {
            var list = new List<RomeNumerics>();
            var romeNumbers = InitArray(romeNums);

            for (int i = 0; i < intNums.Length; i++)
                for (int j = 0; j < romeNumbers.Length; j++)
                {
                    if (intNums[i] == romeNumbers[j].IntValue)
                    {
                        if (list.Contains(romeNumbers[j])) continue;
                        list.Add(romeNumbers[j]);
                        break;
                    }
                }
            return list.OrderBy(i => i.IntValue).ToArray();
        }

        private RomeNumerics[] InitArray(string[] nums)
        {
            var list = new List<RomeNumerics>();
            for (int i = 0; i < stringRomeNums.Length; i++)
            {
                var num = new RomeNumerics(stringRomeNums[i]);
                list.Add(num);
            }
            return list.ToArray();
        }

        private void Sort(RomeNumerics[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
        }
    }
}