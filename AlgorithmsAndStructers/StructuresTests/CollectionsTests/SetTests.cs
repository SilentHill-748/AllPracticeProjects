using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Structures.Collections;

namespace StructuresTests.CollectionsTests
{
    public class SetTests
    {
        private Set<int> _first;
        private Set<int> _second;


        [SetUp]
        public void Init()
        {
            _first = new Set<int>(new int[] { 1, 2, 3, 4, 5 });
            _second = new Set<int>(new int[] { 4, 5, 6, 7, 8 });
        }

        [Test]
        public void Should_Return_Correct_Union_Operation_Test()
        {
            Set<int> expected = new Set<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8 });

            Set<int> actual = _first.Union(_second);

            if (!expected.Equals(actual))
                Assert.Fail("Sets aren't equals!");
        }

        [Test]
        public void Should_Return_Correct_Intersect_Operation_Test()
        {
            Set<int> expected = new Set<int>(new int[] { 4, 5});

            Set<int> actual = _first.Intersect(_second);

            if (!expected.Equals(actual))
                Assert.Fail("Sets aren't equals!");
        }

        [Test]
        public void Should_Return_Correct_Difference_Operation_Test()
        {
            Set<int> expected = new Set<int>(new int[] { 1, 2, 3 });

            Set<int> actual = _first.Difference(_second);

            if (!expected.Equals(actual))
                Assert.Fail("Sets aren't equals!");
        }

        [Test]
        public void Should_Correct_Word_IsSubset_Operation_Test()
        {
            Set<int> set = new Set<int>(new int[] { 3, 4, 5 });

            Assert.IsTrue(_first.IsSubset(set));
            Assert.IsFalse(_second.IsSubset(set));
            Assert.IsFalse(set.IsSubset(_first));
        }

        [Test]
        public void Should_Return_Correct_SymmetricDifference_Operation_Test()
        {
            Set<int> expected = new Set<int>(new int[] { 1, 2, 3, 6, 7, 8 });

            Set<int> actual = _first.SymmetricDifference(_second);

            if (!expected.Equals(actual))
                Assert.Fail("Sets aren't equals!");
        }
    }
}
