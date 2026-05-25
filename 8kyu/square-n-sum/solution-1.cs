public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        return numbers.Select(x => x *= x).Sum();
    }
}
