using Codewars.Solutions.Kyu8.BasicMathematicalOperation;

namespace Codewars.Tests.Kyu8.BasicMathematicalOperationTests;

public class BasicMathematicalOperationTests
{
    [Fact]
    public void Test1()
    {
        var result = BasicMathematicalOperation.Solution('-', 15, 18);
        Assert.Equal(-3, result);
    }
}
