namespace Codewars.Solutions.kyu8.remove_first_and_last_character;

public class RemoveFirstAndLastCharacter
{
    public static string Solution(string s)
    {
        return s[1..^1];
    }
}
