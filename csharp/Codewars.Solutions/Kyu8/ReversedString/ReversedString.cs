using System.Linq;

namespace Codewars.Solutions.Kyu8.ReversedString;

public class ReversedString
{
    public static string Solution1(string str)
    {
        return string.Join("", str.Reverse());
    }

    public static string Solution2(string str)
    {
        return string.Concat(str.Reverse());
    }
}
