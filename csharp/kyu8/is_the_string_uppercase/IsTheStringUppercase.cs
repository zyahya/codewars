namespace Codewars.Solutions.kyu8.is_the_string_uppercase;

public static class IsTheStringUppercase
{
    public static bool Solution(this string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            return false;
        }

        foreach (var c in text)
        {
            if (c == ' ')
            {
                continue;
            }

            if (char.IsLower(c))
            {
                return false;
            }
        }
        return true;
    }
}
