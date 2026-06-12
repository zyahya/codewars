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
touch "$dir/${problem_name}.cpp"

# Changed to EOF (no quotes) so $dir will expand
cat > "$dir/${problem_name}_tests.cpp" <<EOF
#include "../../doctest.h"
#include "./${problem_name}.cpp"

TEST_CASE("$dir")
{
    SUBCASE("Solution 1")
    {
        // CHECK(solution() == );
    }
}
EOF

echo "Created: $dir/${problem_name}.cpp"

# Add entry to root README.md with title and path to the solution (scoped to C++ section)
README_PATH="../README.md"
if [[ -f "$README_PATH" ]]; then
    LEVEL_MD="${kyu}kyu"

    # Make a nicer display title from problem_name (split CamelCase, underscores and dashes)
    DISPLAY_TITLE=$(echo "$problem_name" | sed -r 's/([a-z])([A-Z])/\1 \2/g' | sed -r 's/[_-]+/ /g')

    LINK_PATH="./cpp/${kyu}kyu/${problem_name}/"
    NEW_ROW="| $DISPLAY_TITLE | $LEVEL_MD | [Solution]($LINK_PATH) |"

    awk -v sec="### C++" -v hdr="#### $LEVEL_MD" -v row="$NEW_ROW" '
    BEGIN{inSec=0; sectionExists=0; found=0; inserted=0}
    {
        if($0==sec){ inSec=1; sectionExists=1; print; next }

        if(inSec && $0 ~ /^### / && $0 != sec){
            if(found && !inserted){ print row; inserted=1 }
            inSec=0; print; next
        }

        if(inSec && found==1 && !inserted && $0 ~ /^\|[[:space:]]*-+/){
            print
            print row
            inserted=1
            next
        }

        if(inSec && $0==hdr){ found=1; print; next }

        print
    }
    END{
        if(!inserted){
            if(!sectionExists){
                print ""
                print sec
                print ""
                print "| Problem | Level | Solution |"
                print "| ------- | ----- | -------- |"
                print row
            } else if(sectionExists && !found){
                print ""
                print hdr
                print ""
                print "| Problem | Level | Solution |"
                print "| ------- | ----- | -------- |"
                print row
            } else if(sectionExists && found && !inserted){
                print row
            }
        }
    }' "$README_PATH" > "${README_PATH}.tmp" && mv "${README_PATH}.tmp" "$README_PATH"
fi
