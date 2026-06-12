using System.Linq;

namespace Codewars.Solutions.kyu8.alternate_case;

public static class AlternateCase
{
    public static string Solution(this string s)
    {
        return string.Concat(s.Select(c => char.IsUpper(c) ? c.ToString().ToLower() : c.ToString().ToUpper()).ToArray());
    }
}
