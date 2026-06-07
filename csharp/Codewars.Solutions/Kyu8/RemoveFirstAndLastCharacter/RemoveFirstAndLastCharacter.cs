namespace Codewars.Solutions.Kyu8.RemoveFirstAndLastCharacter;

public class RemoveFirstAndLastCharacter
{
    public static string Solution(string s)
    {
        return s[1..^1];
    }
}
