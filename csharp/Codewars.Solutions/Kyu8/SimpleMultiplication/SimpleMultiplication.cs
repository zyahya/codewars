namespace Codewars.Solutions.Kyu8.SimpleMultiplication;

public class SimpleMultiplication
{
    public static int Multiply(int x)
    {
        return x % 2 == 0 ? x * 8 : x * 9;
    }
}
