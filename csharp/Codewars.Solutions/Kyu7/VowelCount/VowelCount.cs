namespace Codewars.Solutions.Kyu7.VowelCount;

public class VowelCount
{
    public static int Solution1(string str)
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

    public static int Solution2(string str)
    {
        return str.Count("aeoui".Contains);
    }
}
