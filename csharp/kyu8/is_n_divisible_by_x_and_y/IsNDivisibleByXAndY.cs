namespace Codewars.Solutions.kyu8.is_n_divisible_by_x_and_y;

public class IsNDivisibleByXAndY
{
    public static bool Solution(int n, int x, int y)
    {
        return n % x == 0 && n % y == 0;
    }
}
