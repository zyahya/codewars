namespace Codewars.Solutions.kyu8.is_n_divisible_by_x_and_y;

public class IsNDivisibleByXAndYTests
{
    [Theory]
    [InlineData(3, 1, 3, true)]
    [InlineData(12, 2, 6, true)]
    [InlineData(100, 5, 3, false)]
    [InlineData(12, 7, 5, false)]
    public void Should_Check_Divisibility_By_X_And_Y(int n, int x, int y, bool expected)
    {
        var result = IsNDivisibleByXAndY.Solution(n, x, y);

        Assert.Equal(expected, result);
    }
}
