namespace Codewars.Solutions.kyu8.century_from_year;

public class CenturyFromYear
{
    public static int Solution(int year)
    {
        return (int)double.Ceiling((double)year / 100);
    }
}
