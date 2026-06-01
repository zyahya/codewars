using System.Linq;

namespace Codewars.Solutions.Kyu8.SumOfPositive;

public class SumOfPositive
{
    public static int Solution1(int[] arr)
    {
        int sum = 0;

        foreach (int number in arr)
        {
            sum += number > 0 ? number : 0;
        }

        return sum;
    }

    public static int Solution2(int[] arr)
    {
        return arr.Where(num => num > 0).Sum();
    }

    public static int Solution3(int[] arr)
    {
        return arr.Sum(num => num > 0 ? num : 0);
    }
}
