namespace Codewars.Solutions.kyu8.price_of_mangoes;

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
