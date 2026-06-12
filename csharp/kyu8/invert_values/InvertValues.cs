using System.Linq;

namespace Codewars.Solutions.kyu8.InvertValues;

public class InvertValues
{
    public static int[] Solution(int[] input)
    {
        return input.Select(i => -i).ToArray();
    }
}
