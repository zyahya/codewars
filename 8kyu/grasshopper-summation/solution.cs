using System;

public static class Kata
{
    public static int summation(int num)
    {
        int total = 0;
        for (int i = 1; i <= num; i++)
        {
            total += i;
        }
        return total;
    }
}
