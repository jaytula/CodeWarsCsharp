using System;

using NUnit.Framework;

[TestFixture]
public class FuncijTests
{

	Random randomGenerator = new Random();

	[Test]
	public void Test01()
	{
        Assert.AreEqual(204, Funcij.sumin(8));
        Assert.AreEqual(55, Funcij.sumin(5));
        Assert.AreEqual(30, Funcij.sumin(4));
        Assert.AreEqual(14, Funcij.sumin(3));
        Assert.AreEqual(5, Funcij.sumin(2));
        Assert.AreEqual(1, Funcij.sumin(1));
    }
    [Test]
    public void Test04()
    {
        Assert.AreEqual(1, Funcij.sumax(1));
        Assert.AreEqual(7, Funcij.sumax(2));
        Assert.AreEqual(22, Funcij.sumax(3));
        Assert.AreEqual(50, Funcij.sumax(4));
        Assert.AreEqual(372, Funcij.sumax(8));
    }
    [Test]
    public void Test05()
    {
        Assert.AreEqual(576, Funcij.sumsum(8));
    }

}

/**
 *   1 2 3 4 5 6
 * 1 1 2 3 4 5 6
 * 2 2 2 3 4 5 6
 * 3 3 3 3 4 5 6
 * 4 4 4 4 4 5 6
 * 5 5 5 5 5 5 6
 * 6 6 6 6 6 6 6
 */