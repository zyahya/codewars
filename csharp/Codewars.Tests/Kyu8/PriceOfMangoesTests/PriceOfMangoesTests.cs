using Codewars.Solutions.Kyu8.PriceOfMangoes;

namespace Codewars.Tests.Kyu8.PriceOfMangoesTests;

public class PriceOfMangoesTests
{
    [Theory]
    [InlineData(3, 3, 6)]
    [InlineData(9, 5, 30)]
    public void Test1(int quantity, int price, int expectedResult)
    {
        var result = PriceOfMangoes.Solution(quantity, price);

        Assert.Equal(expectedResult, result);
    }
}
