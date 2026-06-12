from .even_or_odd import solution
import pytest


@pytest.mark.parametrize(
    "number, expected",
    [
        (1, "Odd"),
        (2, "Even"),
        (-1, "Odd"),
        (200, "Even"),
    ],
)
def test_even_or_odd(number, expected):
    assert solution(number) is expected
