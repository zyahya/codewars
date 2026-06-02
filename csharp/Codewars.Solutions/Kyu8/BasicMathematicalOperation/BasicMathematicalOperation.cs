using System;
using System.Data;

namespace Codewars.Solutions.Kyu8.BasicMathematicalOperation;

public class BasicMathematicalOperation
{
    public static double Solution(char operation, double value1, double value2)
    {
        return Convert.ToDouble(new DataTable().Compute($"{value1} {operation} {value2}", string.Empty));
    }
}
