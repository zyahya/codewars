public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        int sum = 0;

        foreach (int number in arr)
        {
            sum += number > 0 ? number : 0;
        }

        return sum;
    }
}
