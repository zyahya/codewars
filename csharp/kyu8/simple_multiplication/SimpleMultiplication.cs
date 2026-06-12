namespace Codewars.Solutions.kyu8.simple_multiplication;

public class SimpleMultiplication
{
    public static int Multiply(int x)
    {
        return x % 2 == 0 ? x * 8 : x * 9;
    }
}
