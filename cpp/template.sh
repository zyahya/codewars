#!/usr/bin/env bash

set -e

if [ $# -lt 2 ]; then
    echo "Usage: $0 <kyu(1-8)> <problem-name>"
    exit 1
fi

kyu="$1"
shift

problem_name="$*"

if ! [[ "$kyu" =~ ^[1-8]$ ]]; then
    echo "Error: kyu must be a number from 1 to 8."
    exit 1
fi

dir="${kyu}kyu/${problem_name}"

mkdir -p "$dir"
touch "$dir/README.md"

# Left as 'EOF' because solution.cpp doesn't need Bash variables
cat > "$dir/solution.cpp" <<'EOF'
#include <cassert>

namespace solution
{

}
EOF

# Changed to EOF (no quotes) so $dir will expand
cat > "$dir/test.cpp" <<EOF
#include "../../doctest.h"
#include "./solution.cpp"

TEST_CASE("$dir")
{
    SUBCASE("Solution 1")
    {
        // CHECK(solution::solution() == );
    }
}
EOF

echo "Created: $dir/solution.cpp"
