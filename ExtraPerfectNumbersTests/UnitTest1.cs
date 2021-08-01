namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(new int[] { 1, 3 }, Kata.ExtraPerfect(3));
            Assert.AreEqual(new int[] { 1, 3, 5 }, Kata.ExtraPerfect(5));
            Assert.AreEqual(new int[] { 1, 3, 5, 7 }, Kata.ExtraPerfect(7));
            Assert.AreEqual(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27 }, Kata.ExtraPerfect(28));
            Assert.AreEqual(new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39 }, Kata.ExtraPerfect(39));
        }
    }
}