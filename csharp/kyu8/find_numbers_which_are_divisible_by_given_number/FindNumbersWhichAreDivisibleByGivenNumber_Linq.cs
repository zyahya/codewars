using System.Linq;

namespace Codewars.Solutions.kyu8.find_numbers_which_are_divisible_by_given_number;

public class FindNumbersWhichAreDivisibleByGivenNumber_Linq
{
    public static int[] Solution(int[] numbers, int divisor)
    {
        return numbers.Where(n => n % divisor == 0).ToArray();
    }
}
