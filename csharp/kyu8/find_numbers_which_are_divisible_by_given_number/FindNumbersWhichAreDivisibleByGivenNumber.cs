using System.Collections.Generic;

namespace Codewars.Solutions.kyu8.find_numbers_which_are_divisible_by_given_number;

public class FindNumbersWhichAreDivisibleByGivenNumber
{
    public static int[] Solution(int[] numbers, int divisor)
    {
        List<int> result = [];

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % divisor == 0)
            {
                result.Add(numbers[i]);
            }
        }

        return result.ToArray();
    }
}
