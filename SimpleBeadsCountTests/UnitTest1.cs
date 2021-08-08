namespace Solution
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class SampleTests
    {
        [Test, Description("Basic Tests")]
        public void SampleTest()
        {
            Assert.That(Kata.CountRedBeads(0), Is.EqualTo(0));
            Assert.That(Kata.CountRedBeads(1), Is.EqualTo(0));
            Assert.That(Kata.CountRedBeads(3), Is.EqualTo(4));
            Assert.That(Kata.CountRedBeads(5), Is.EqualTo(8));
        }
    }
}