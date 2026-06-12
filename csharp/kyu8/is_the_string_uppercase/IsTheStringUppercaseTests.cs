namespace Codewars.Solutions.kyu8.is_the_string_uppercase;

public class IsTheStringUppercaseTests
{
    [Theory]
    [InlineData("c", false)]
    [InlineData("C", true)]
    [InlineData("hello I AM DONALD", false)]
    [InlineData("HELLO I AM DONALD", true)]
    [InlineData("ACSKLDFJSgSKLDFJSKLDFJ", false)]
    [InlineData("ACSKLDFJSGSKLDFJSKLDFJ", true)]
    public void Test1(string input, bool expectedResult)
    {
        var result = IsTheStringUppercase.Solution(input);

        Assert.Equal(expectedResult, result);
    }
}
