using System.Linq;

namespace Codewars.Solutions.kyu8.SquareNSum;

public class SquareNSum
{
    public static int Solution(int[] numbers)
    {
        return numbers.Select(x => x *= x).Sum();
    }
}
