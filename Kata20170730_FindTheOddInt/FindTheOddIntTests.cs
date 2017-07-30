using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170730_FindTheOddInt
{
    [TestClass]
    public class FindTheOddIntTests
    {
        [TestMethod]
        public void input_2_2_should_return_0()
        {
            AssertFindOddShouldBe(new[] { 2, 2 }, 0);
        }

        [TestMethod]
        public void input_2_2_1_should_return_1()
        {
            AssertFindOddShouldBe(new[] { 2, 2, 1 }, 1);
        }

        [TestMethod]
        public void inputn_20_1_n1_2_n2_3_3_5_5_1_2_4_20_4_n1_n2_5_should_return_5()
        {
            AssertFindOddShouldBe(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }, 5);
        }

        private static void AssertFindOddShouldBe(int[] seq, int expected)
        {
            var kata = new Kata();
            var actual = kata.find_it(seq);
            Assert.AreEqual(expected, actual);
        }
    }

    public class Kata
    {
        public int find_it(int[] seq)
        {
            return seq.GroupBy(a => a).FirstOrDefault(a => a.Count() % 2 != 0)?.Key ?? 0;
        }
    }
}
