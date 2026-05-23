public class Kata
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Sum(num => num > 0 ? num : 0);
    }
}
