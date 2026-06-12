#include <cassert>
#include <string>

namespace solution_bit
{

std::string solution(const std::string &str)
{
    std::string newStr;

    for (int i = 0; i < str.length(); i++)
    {
        if (('A' <= str[i] && str[i] <= 'Z') || ('a' <= str[i] && str[i] <= 'z'))
        {
            newStr += str[i] ^ (1 << 5);
        }
        else
        {
            newStr += str[i];
        }
    }

    return newStr;
}

} // namespace solution_bit
