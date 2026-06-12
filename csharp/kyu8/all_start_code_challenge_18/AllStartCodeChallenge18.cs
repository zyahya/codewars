using System;

namespace Codewars.Solutions.kyu8.all_start_code_challenge_18;

public class AllStartCodeChallenge18
{
    public static int Solution(string str, char letter)
    {
        return MemoryExtensions.Count(str, letter);
    }
}
