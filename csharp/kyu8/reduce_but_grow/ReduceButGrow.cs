using System.Linq;

namespace Codewars.Solutions.kyu8.ReduceButGrow;

public class ReduceButGrow
{
    public static int Grow(int[] x)
    {
        return x.Aggregate((a, b) => a * b);
    }
}
