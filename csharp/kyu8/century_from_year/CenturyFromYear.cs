namespace Codewars.Solutions.kyu8.CenturyFromYear;

public class CenturyFromYear
{
    public static int Solution(int year)
    {
        return (int)double.Ceiling((double)year / 100);
    }
}
