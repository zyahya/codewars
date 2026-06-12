#include "../../doctest.h"
#include "./alternating_case_bit.cpp"
#include "./alternating_case_std.cpp"

TEST_CASE("alternate_case")
{
    SUBCASE("solution 1")
    {
        CHECK(solution_bit::solution("AbC") == "aBc");
        CHECK(solution_bit::solution("HELLO WORLD") == "hello world");
        CHECK(solution_bit::solution("1234") == "1234");
        CHECK(solution_bit::solution("1a2b3c4d5e") == "1A2B3C4D5E");
        CHECK(solution_bit::solution("String.prototype.toAlternatingCase") == "sTRING.PROTOTYPE.TOaLTERNATINGcASE");
        CHECK(solution_bit::solution("altERnaTIng cAsE") == "ALTerNAtiNG CaSe");
        CHECK(solution_bit::solution("altERnaTIng cAsE <=> ALTerNAtiNG CaSe") ==
              "ALTerNAtiNG CaSe <=> altERnaTIng cAsE");
    }

    SUBCASE("solution 2")
    {
        CHECK(solution_std::solution("AbC") == "aBc");
        CHECK(solution_std::solution("HELLO WORLD") == "hello world");
        CHECK(solution_std::solution("1234") == "1234");
        CHECK(solution_std::solution("1a2b3c4d5e") == "1A2B3C4D5E");
        CHECK(solution_std::solution("String.prototype.toAlternatingCase") == "sTRING.PROTOTYPE.TOaLTERNATINGcASE");
        CHECK(solution_std::solution("altERnaTIng cAsE") == "ALTerNAtiNG CaSe");
        CHECK(solution_std::solution("altERnaTIng cAsE <=> ALTerNAtiNG CaSe") ==
              "ALTerNAtiNG CaSe <=> altERnaTIng cAsE");
    }
}
