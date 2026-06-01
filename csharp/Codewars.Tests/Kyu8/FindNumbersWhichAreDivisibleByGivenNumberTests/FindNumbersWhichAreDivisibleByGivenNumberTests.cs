using Codewars.Solutions.Kyu8.FindNumbersWhichAreDivisibleByGivenNumber;

namespace Codewars.Tests.Kyu8.FindNumbersWhichAreDivisibleByGivenNumberTests;

public class FindNumbersWhichAreDivisibleByGivenNumberTests
{
    [Fact]
    public void Test1()
    {
        var result = FindNumbersWhichAreDivisibleByGivenNumber.Solution([1, 2, 3, 4, 5, 6], 2);

        Assert.Equal([2, 4, 6], result);
    }

    [Fact]
    public void Test2()
    {
        var result = FindNumbersWhichAreDivisibleByGivenNumber_Linq.Solution([1, 2, 3, 4, 5, 6], 2);

        Assert.Equal([2, 4, 6], result);
    }
}
