using System;

namespace Codewars.Solutions.Kyu8.AllStartCodeChallenge18;

public class AllStartCodeChallenge18
{
    public static int Solution(string str, char letter)
    {
        return MemoryExtensions.Count(str, letter);
    }
}
