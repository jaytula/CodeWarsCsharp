namespace Solution
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class SampleTests
    {
        private static IEnumerable<TestCaseData> testCases
        {
            get
            {
                yield return new TestCaseData(0, 0).Returns(true).SetDescription("Origin is inside");
                yield return new TestCaseData(2, 0).Returns(false).SetDescription("(2, 0) is outside");
                yield return new TestCaseData(0, 0.9).Returns(true).SetDescription("(0, 0.9) is inside");
                yield return new TestCaseData(0.5, 0.5).Returns(true).SetDescription("(0.5, 0.5) is inside");
            }
        }

        [Test, TestCaseSource("testCases")]
        public bool Test(double x, double y) =>
          Kata.PointInCircle(x, y);
    }
}