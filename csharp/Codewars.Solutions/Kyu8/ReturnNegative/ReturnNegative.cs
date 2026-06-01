using System;

namespace Codewars.Solutions.Kyu8.ReturnNegative;

public class ReturnNegative
{
    public static int Solution1(int number)
    {
        return number <= 0 ? number : -number;
    }

    public static int Solution2(int number)
    {
        return -Math.Abs(number);
    }
}
