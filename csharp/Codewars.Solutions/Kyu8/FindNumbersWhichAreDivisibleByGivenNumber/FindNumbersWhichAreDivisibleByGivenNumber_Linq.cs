using System.Linq;

namespace Codewars.Solutions.Kyu8.FindNumbersWhichAreDivisibleByGivenNumber;

public class FindNumbersWhichAreDivisibleByGivenNumber_Linq
{
    public static int[] Solution(int[] numbers, int divisor)
    {
        return numbers.Where(n => n % divisor == 0).ToArray();
    }
}
