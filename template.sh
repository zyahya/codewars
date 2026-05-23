#!/bin/bash

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
