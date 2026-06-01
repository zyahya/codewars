using System;

namespace Codewars.Solutions.Kyu8.LeapYears;

public class LeapYears
{
    public static bool Solution1(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }

    public static bool Solution2(int year)
    {
        return DateTime.IsLeapYear(year);
    }
}
