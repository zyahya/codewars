#!/usr/bin/env bash

LEVEL="$1"
PROBLEM_NAME="$2"

if [[ -z "$LEVEL" || -z "$PROBLEM_NAME" ]]; then
	echo "Usage: $0 <LevelNumber> <ProblemName>"
	echo "Example: $0 8 SquareNSum"
	exit 1
fi

# Normalize common level aliases like 8 or 8Kyu -> Kyu8
if [[ "$LEVEL" =~ ^([0-9]+)$ ]]; then
	LEVEL="Kyu${BASH_REMATCH[1]}"
elif [[ "$LEVEL" =~ ^([0-9]+)[Kk]yu$ ]]; then
	LEVEL="Kyu${BASH_REMATCH[1]}"
fi

mkdir -p "./Codewars.Solutions/$LEVEL/$PROBLEM_NAME"
dotnet new class --name "$PROBLEM_NAME" --output "./Codewars.Solutions/$LEVEL/$PROBLEM_NAME" --force
touch "./Codewars.Solutions/$LEVEL/$PROBLEM_NAME/README.md"

mkdir -p "./Codewars.Tests/$LEVEL/${PROBLEM_NAME}Tests"
dotnet new class --name "${PROBLEM_NAME}Tests" --output "./Codewars.Tests/$LEVEL/${PROBLEM_NAME}Tests" --force

# Fix the namespace in the generated file
sed -i "s/namespace Codewars.Solutions;/namespace Codewars.Solutions.$LEVEL.$PROBLEM_NAME;/" "./Codewars.Solutions/$LEVEL/$PROBLEM_NAME/$PROBLEM_NAME.cs"

sed -i "s/namespace Codewars.Tests;/namespace Codewars.Tests.$LEVEL.${PROBLEM_NAME}Tests;/" "./Codewars.Tests/$LEVEL/${PROBLEM_NAME}Tests/${PROBLEM_NAME}Tests.cs"

# Add entry to root README.md with title and path to the solution
README_PATH="../README.md"
if [[ -f "$README_PATH" ]]; then
	if [[ "$LEVEL" =~ ^Kyu([0-9]+)$ ]]; then
		NUM="${BASH_REMATCH[1]}"
	else
		NUM="$LEVEL"
	fi
	LEVEL_MD="${NUM}kyu"

	# Make a nicer display title from PROBLEM_NAME (split CamelCase, underscores and dashes)
	DISPLAY_TITLE=$(echo "$PROBLEM_NAME" | sed -r 's/([a-z])([A-Z])/\1 \2/g' | sed -r 's/[_-]+/ /g')

	# Link path relative to repo README.md
	LINK_PATH="./csharp/Codewars.Solutions/$LEVEL/$PROBLEM_NAME/"
	NEW_ROW="| $DISPLAY_TITLE | $LEVEL_MD | [Solution]($LINK_PATH) |"

	# Insert the new row inside the `### C#` section only. If the section/header/table
	# doesn't exist, create them. Do not modify other language sections.
	awk -v sec="### C#" -v hdr="#### $LEVEL_MD" -v row="$NEW_ROW" '
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
