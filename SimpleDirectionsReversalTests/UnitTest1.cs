using NUnit.Framework;
using System;

[TestFixture]
public class SolutionTest
{
    [Test]
    public void ExampleTests()
    {
        Assert.AreEqual(new String[] { "Begin on Road D", "Right on Road C", "Left on Road B", "Left on Road A" }, Solution.solve(new String[] { "Begin on Road A", "Right on Road B", "Right on Road C", "Left on Road D" }));
        Assert.AreEqual(new String[] { "Begin on 9th Dr", "Right on First Road", "Left on 3rd Blvd" }, Solution.solve(new String[] { "Begin on 3rd Blvd", "Right on First Road", "Left on 9th Dr" }));
        Assert.AreEqual(new String[] { "Begin on Road A" }, Solution.solve(new String[] { "Begin on Road A" }));

    }
}