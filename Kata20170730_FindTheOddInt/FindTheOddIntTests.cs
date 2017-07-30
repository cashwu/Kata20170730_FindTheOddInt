﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170730_FindTheOddInt
{
    [TestClass]
    public class FindTheOddIntTests
    {
        [TestMethod]
        public void input_2_2_should_return_0()
        {
            AssertFindOddShouldBe(new[] {2, 2}, 0);
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
            return 0;
        }
    }
}
