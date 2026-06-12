namespace Codewars.Solutions.kyu8.sum_the_strings;

public class SumTheStrings
{
    public static string Solution(string s1, string s2)
    {
        int.TryParse(s1, out int n1);
        int.TryParse(s2, out int n2);
        return string.Concat(n1 + n2);
    }
}
