using System;

namespace Codewars.Solutions.kyu8.counting_sheep;

public class CountingSheep
{
    public static int Solution(bool[] sheeps)
    {
        return sheeps.Count(true);
    }
}
