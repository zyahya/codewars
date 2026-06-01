namespace Codewars.Solutions.Kyu8.GrasshopperSummation;

public class GrasshopperSummation
{
    public static int Solution(int num)
    {
        int total = 0;
        for (int i = 1; i <= num; i++)
        {
            total += i;
        }
        return total;
    }
}
