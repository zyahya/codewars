#include "../../doctest.h"
#include "multiply.cpp"

TEST_CASE("multiply test cases")
{
    SUBCASE("Solution 1")
    {
        CHECK(solution(1, 2) == 2);
        CHECK(solution(4, 2) == 8);
    }
}
