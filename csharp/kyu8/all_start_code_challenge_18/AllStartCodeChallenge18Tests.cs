namespace Codewars.Solutions.kyu8.all_start_code_challenge_18;

public class AllStartCodeChallenge18Tests
{
    [Theory]
    [InlineData("Hello world", 'o', 2)]
    [InlineData("Hello", 'l', 2)]
    [InlineData("Hello", 'H', 1)]
    [InlineData("abcabcabc", 'a', 3)]
    public void Test1(string text, char c, int expected)
    {
        var result = AllStartCodeChallenge18.Solution(text, c);
        Assert.Equal(expected, result);
    }
}
