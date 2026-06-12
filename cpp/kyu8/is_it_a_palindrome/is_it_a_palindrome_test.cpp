#include "../../doctest.h"
#include "./is_it_a_palindrome.cpp"

TEST_CASE("8kyu/is_it_a_palindrome")
{
    SUBCASE("Solution 1")
    {
        CHECK(solution("madam") == true);
        CHECK(solution("a") == true);
        CHECK(solution("aba") == true);
        CHECK(solution("Abba") == true);
        CHECK(solution("hello") == false);
    }
}
