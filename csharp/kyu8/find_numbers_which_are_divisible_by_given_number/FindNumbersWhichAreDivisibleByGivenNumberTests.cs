namespace Codewars.Solutions.kyu8.find_numbers_which_are_divisible_by_given_number;

public class FindNumbersWhichAreDivisibleByGivenNumberTests
{
    [Fact]
    public void Test1()
    {
        var result = FindNumbersWhichAreDivisibleByGivenNumber.Solution([1, 2, 3, 4, 5, 6], 2);

        Assert.Equal([2, 4, 6], result);
    }

    [Fact]
    public void Test_With_Linq()
    {
        var result = FindNumbersWhichAreDivisibleByGivenNumber_Linq.Solution([1, 2, 3, 4, 5, 6], 2);

        Assert.Equal([2, 4, 6], result);
    }
}
