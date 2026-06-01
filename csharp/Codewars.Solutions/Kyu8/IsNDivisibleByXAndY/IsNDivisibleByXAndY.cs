namespace Codewars.Solutions.Kyu8.IsNDivisibleByXAndY;

public class IsNDivisibleByXAndY
{
    public static bool Solution(int n, int x, int y)
    {
        return n % x == 0 && n % y == 0;
    }
}
