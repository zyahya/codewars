namespace Codewars.Solutions.kyu8.basic_mathematical_operation;

public class BasicMathematicalOperationTests
{
    [Fact]
    public void Test1()
    {
        var result = BasicMathematicalOperation.Solution('-', 15, 18);
        Assert.Equal(-3, result);
    }
}
