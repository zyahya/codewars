using System;
using System.Data;

namespace Codewars.Solutions.kyu8.basic_mathematical_operation;

public class BasicMathematicalOperation
{
    public static double Solution(char operation, double value1, double value2)
    {
        return Convert.ToDouble(new DataTable().Compute($"{value1} {operation} {value2}", string.Empty));
    }
}
