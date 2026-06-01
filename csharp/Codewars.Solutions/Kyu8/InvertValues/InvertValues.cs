using System.Linq;

namespace Codewars.Solutions.Kyu8.InvertValues;

public class InvertValues
{
    public static int[] Solution(int[] input)
    {
        return input.Select(i => -i).ToArray();
    }
}
