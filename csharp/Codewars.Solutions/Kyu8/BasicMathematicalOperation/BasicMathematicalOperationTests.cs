namespace Codewars.Solutions.Kyu8.BasicMathematicalOperation;

public class BasicMathematicalOperationTests
{
    [Fact]
    public void Test1()
    {
        var result = BasicMathematicalOperation.Solution('-', 15, 18);
        Assert.Equal(-3, result);
    }
}
