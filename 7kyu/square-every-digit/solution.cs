using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static int SquareDigits(int n)
    {
        return n.ConvertIntToIntList() // 523 => "523" => ['5', '2', '3'] => [5, 2, 3]
            .PowerEachItem() // [5, 2, 3] => [25, 4, 9]
            .ConcatIntList(); // [25, 4, 9] => "2549" => 2549
    }
}

public static class Helpers
{
    public static List<int> ConvertIntToIntList(this int value)
    {
        return Convert.ToString(value)
            .ToList()
            .ConvertAll(c => (int)char.GetNumericValue(c));
    }

    public static List<int> PowerEachItem(this List<int> value)
    {
        return value.Select(i => i * i).ToList();
    }

    public static int ConcatIntList(this List<int> value)
    {
        return Convert.ToInt32(
            value.ConvertIntListToString()
        );
    }

    public static string ConvertIntListToString(this List<int> value)
    {
        return string.Concat(value);
    }
}
