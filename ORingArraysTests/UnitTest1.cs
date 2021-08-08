using NUnit.Framework;
using System;
class ExampleTest
{
    [Test]
    public void FixedTest()
    {
        Assert.AreEqual(new[] { 1, 2, 3 }, Kata.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }));
        Assert.AreEqual(new[] { 5, 7, 7 }, Kata.OrArrays(new[] { 1, 2, 3 }, new[] { 4, 5, 6 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, Kata.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, Kata.OrArrays(new[] { 1, 2 }, new[] { 1, 2, 3 }));
        Assert.AreEqual(new[] { 1, 2, 3 }, Kata.OrArrays(new[] { 1, 2, 3 }, new[] { 1, 2, 3 }, 3));
    }
}