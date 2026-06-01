using System;

namespace Codewars.Solutions.Kyu8.CountingSheep;

public class CountingSheep
{
    public static int Solution(bool[] sheeps)
    {
        return sheeps.Count(true);
    }
}
