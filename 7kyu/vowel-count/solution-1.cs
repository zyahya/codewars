using System;
using System.Collections.Generic;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;

        for (int i = 0; i < str.Length; i++)
        {
            switch (str[i])
            {
                case 'a':
                case 'e':
                case 'o':
                case 'u':
                case 'i':
                    vowelCount++;
                    break;
            }
        }

        return vowelCount;
    }
}
