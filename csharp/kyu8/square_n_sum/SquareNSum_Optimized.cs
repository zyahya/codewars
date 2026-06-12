using System.Linq;

namespace Codewars.Solutions.kyu8.square_n_sum;

public class SquareNSum_Optimized
{
    public static int Solution(int[] numbers)
    {
        return numbers.Sum(x => x * x);
    }
}
