#!/usr/bin/env bash

LEVEL="$1"
PROBLEM_NAME="$2"

if [[ -z "$LEVEL" || -z "$PROBLEM_NAME" ]]; then
	echo "Usage: $0 <KyuLevel> <ProblemName>"
	echo "Example: $0 Kyu8 square-n-sum"
	exit 1
fi

# Normalize common level aliases like 8Kyu -> Kyu8
if [[ "$LEVEL" =~ ^([0-9]+)[Kk]yu$ ]]; then
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
