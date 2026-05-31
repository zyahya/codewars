#!/bin/bash

# Show help message
if [[ "$1" == "-h" || "$1" == "--help" ]]; then
    echo "Usage: $0 <directory-path> [extension]"
    echo "  <directory-path>   Directory to create (required)"
    echo "  [extension]        File extension for solution file (default: cs)"
    echo "Options:"
    echo "  -h, --help         Show this help message and exit"
    exit 0
fi

# Check if directory path is provided
if [ -z "$1" ]; then
    echo "Usage: $0 <directory-path> [extension]"
    exit 1
fi

DIR="$1"
EXT="${2:-cs}"  # Default extension is 'cs' if not provided

# Check if directory already exists
if [ -d "$DIR" ]; then
    echo "Directory '$DIR' already exists."
    exit 1
fi

# Create the directory
mkdir -p "$DIR"

# Create solution file with the specified extension and README.md inside the directory
touch "$DIR/solution.$EXT"
touch "$DIR/README.md"

echo "Created '$DIR' with solution.$EXT and README.md."

# Append entry to README.md in the required format
PROBLEM_NAME=$(basename "$DIR" | sed 's/-/ /g; s/\b\w/\u&/g')
LEVEL=$(echo "$DIR" | grep -oE '^[^/\\]+' | tr '[:lower:]' '[:upper:]')
if [[ "$LEVEL" == "7KYU" || "$LEVEL" == "8KYU" ]]; then
    LEVEL_LOWER=$(echo "$LEVEL" | tr '[:upper:]' '[:lower:]')
    # Only 7kyu and 8kyu supported for now
else
    LEVEL_LOWER=""
fi
if [[ -n "$LEVEL_LOWER" ]]; then
    # Compose the line in the required format
    NEW_LINE="| $PROBLEM_NAME | $LEVEL_LOWER  | [solution](./$DIR/) |       |"

    # Insert into the correct level section table (after header separator)
    TMP_FILE=$(mktemp)
    awk -v level="$LEVEL_LOWER" -v newline="$NEW_LINE" '
        BEGIN { section=0; inserted=0 }
        {
            print $0
            if ($0 ~ "^### " level "$") {
                section=1
            } else if ($0 ~ "^# " && section==1) {
                section=0
            }

            if (section==1 && $0 ~ /^\|[[:space:]]*-+/ && inserted==0) {
                print newline
                inserted=1
            }
        }
        END { if (inserted==0) { print newline } }
    ' README.md > "$TMP_FILE"
    mv "$TMP_FILE" README.md
fi
