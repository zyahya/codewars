#include <cassert>
#include <cctype>
#include <string>

std::string solution(const std::string &str)
{
    std::string newStr;

    for (int i = 0; i < str.length(); i++)
    {
        if (std::islower(str[i]))
        {
            newStr += std::toupper(str[i]);
        }
        else if (std::isupper(str[i]))
        {
            newStr += std::tolower(str[i]);
        }
        else
        {
            newStr += str[i];
        }
    }

    return newStr;
}

int main()
{
    assert(solution("AbC") == "aBc");
    assert(solution("HELLO WORLD") == "hello world");
    assert(solution("1234") == "1234");
    assert(solution("1a2b3c4d5e") == "1A2B3C4D5E");
    assert(solution("String.prototype.toAlternatingCase") == "sTRING.PROTOTYPE.TOaLTERNATINGcASE");
    assert(solution("altERnaTIng cAsE") == "ALTerNAtiNG CaSe");
    assert(solution("altERnaTIng cAsE <=> ALTerNAtiNG CaSe") == "ALTerNAtiNG CaSe <=> altERnaTIng cAsE");

    return 0;
}
