using System;

namespace Codewars.Solutions.kyu8.CountingSheep;

public class CountingSheep
{
    public static int Solution(bool[] sheeps)
    {
        return sheeps.Count(true);
    }
}
