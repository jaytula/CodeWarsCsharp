namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class KataTest
    {
        [Test]
        public void BasicTests()
        {
            Assert.AreEqual(2, Kata.Consecutive(new int[] { 4, 8, 6 }));
            Assert.AreEqual(0, Kata.Consecutive(new int[] { 1, 2, 3, 4 }));
            Assert.AreEqual(0, Kata.Consecutive(new int[] { }));
            Assert.AreEqual(0, Kata.Consecutive(new int[] { 1 }));
        }
    }
}