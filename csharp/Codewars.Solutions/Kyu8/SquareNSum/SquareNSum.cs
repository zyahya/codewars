namespace Codewars.Solutions.Kyu8.SquareNSum;

public class SquareNSum
{
    public static int Solution1(int[] numbers)
    {
        return numbers.Select(x => x *= x).Sum();
    }

    public static int Solution2(int[] numbers)
    {
        return numbers.Sum(x => x * x);
    }
}
