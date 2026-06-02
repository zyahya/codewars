using System.Linq;

namespace Codewars.Solutions.Kyu8.AlternateCase;

public static class AlternateCase
{
    public static string Solution(this string s)
    {
        return string.Concat(s.Select(c => char.IsUpper(c) ? c.ToString().ToLower() : c.ToString().ToUpper()).ToArray());
    }
}
