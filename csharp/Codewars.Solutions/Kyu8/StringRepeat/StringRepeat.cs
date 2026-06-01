using System.Linq;

namespace Codewars.Solutions.Kyu8.StringRepeat;

public class StringRepeat
{
    public static string RepeatStr(int n, string s)
    {
        return string.Concat(Enumerable.Repeat(s, n));
    }
}
