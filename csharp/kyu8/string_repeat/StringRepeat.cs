using System.Linq;

namespace Codewars.Solutions.kyu8.string_repeat;

public class StringRepeat
{
    public static string RepeatStr(int n, string s)
    {
        return string.Concat(Enumerable.Repeat(s, n));
    }
}
