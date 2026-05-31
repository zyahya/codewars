using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(true);
    }
}
