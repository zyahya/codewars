#include <cassert>
#include <cctype>
#include <string>

namespace solution_std
{

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

} // namespace solution_std
