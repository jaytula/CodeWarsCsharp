namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("Basic Tests")]
        public void BasicTest()
        {
            Assert.That(Kata.Doubles("abbbzz"), Is.EqualTo("ab"));
            Assert.That(Kata.Doubles("zzzzykkkd"), Is.EqualTo("ykd"));
            Assert.That(Kata.Doubles("abbcccdddda"), Is.EqualTo("aca"));
            Assert.That(Kata.Doubles("vvvvvoiiiiin"), Is.EqualTo("voin"));
            Assert.That(Kata.Doubles("rrrmooomqqqqj"), Is.EqualTo("rmomj"));
            Assert.That(Kata.Doubles("xxbnnnnnyaaaaam"), Is.EqualTo("bnyam"));
            Assert.That(Kata.Doubles("aaabbbbaaa"), Is.EqualTo(""));
        }

    }
}