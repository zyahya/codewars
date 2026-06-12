#!/usr/bin/env python3
import os
import re
from pathlib import Path

# --- CONFIGURATION ---
README_PATH = Path("README.md")
START_MARKER = "<!-- Start Table -->"
END_MARKER = "<!-- End Table -->"

# Directories at the root level to completely ignore
IGNORE_DIRS = {".git", ".github", ".vscode", "node_modules", "assets"}

# Prettify language folder names for headings
LANGUAGE_MAPPING = {
    "c": "C",
    "cpp": "C++",
    "csharp": "C#",
    "javascript": "JavaScript",
    "python": "Python",
    "typescript": "TypeScript",
}


def extract_kyu_number(diff_str):
    """Extracts the number from kyu strings (e.g., 'kyu8' -> 8) for sorting."""
    match = re.search(r"\d+", diff_str)
    return int(match.group()) if match else 0


def get_solutions_data():
    """Scans the repository and builds a structured dictionary of solutions."""
    solutions = {}
    root = Path(".")

    # 1. Scan Languages
    for lang_dir in root.iterdir():
        if lang_dir.is_dir() and lang_dir.name not in IGNORE_DIRS:
            lang_name = lang_dir.name

            # 2. Scan Difficulty Levels (e.g., kyu1, kyu8)
            for diff_dir in lang_dir.iterdir():
                if diff_dir.is_dir() and diff_dir.name.startswith("kyu"):
                    diff_name = diff_dir.name

                    # 3. Scan Individual Problems
                    for prob_dir in diff_dir.iterdir():
                        if prob_dir.is_dir():
                            prob_name = prob_dir.name

                            # Convert snake_case or kebab-case to Title Case
                            prob_title = (
                                prob_name.replace("_", " ").replace("-", " ").title()
                            )

                            # Generate relative path for Markdown linking
                            rel_path = f"./{lang_name}/{diff_name}/{prob_name}/"

                            # Initialize map structures safely
                            if lang_name not in solutions:
                                solutions[lang_name] = {}
                            if diff_name not in solutions[lang_name]:
                                solutions[lang_name][diff_name] = []

                            solutions[lang_name][diff_name].append(
                                {"title": prob_title, "path": rel_path}
                            )
    return solutions


def build_markdown_tables(solutions):
    """Generates the Markdown string containing sections and tables."""
    markdown_lines = []

    # Sort languages alphabetically
    for lang in sorted(solutions.keys()):
        lang_title = LANGUAGE_MAPPING.get(lang.lower(), lang.title())
        markdown_lines.append(f"### {lang_title}\n")

        # CHANGED HERE: Removed reverse=True so lower numbers (kyu1) come first
        sorted_diffs = sorted(solutions[lang].keys(), key=extract_kyu_number)

        for diff in sorted_diffs:
            markdown_lines.append(f"#### {diff}\n")
            markdown_lines.append("| Problem | Level | Solution |")
            markdown_lines.append("| :--- | :---: | :--- |")

            # Sort individual problems alphabetically by title
            sorted_probs = sorted(solutions[lang][diff], key=lambda x: x["title"])
            for prob in sorted_probs:
                markdown_lines.append(
                    f"| {prob['title']} | {diff} | [Solution]({prob['path']}) |"
                )

            markdown_lines.append("")  # Empty line spacing between tables

    return "\n".join(markdown_lines).strip()


def update_readme(new_markdown):
    """Injects the generated markdown between the designated markers in README.md."""
    if not README_PATH.exists():
        default_structure = (
            f"# Code Solutions\n\n## Solutions\n\n{START_MARKER}\n{END_MARKER}\n"
        )
        README_PATH.write_text(default_structure, encoding="utf-8")

    content = README_PATH.read_text(encoding="utf-8")

    pattern = re.compile(
        f"{re.escape(START_MARKER)}.*{re.escape(END_MARKER)}", re.DOTALL
    )
    replacement = f"{START_MARKER}\n\n{new_markdown}\n\n{END_MARKER}"

    if START_MARKER in content and END_MARKER in content:
        updated_content = pattern.sub(replacement, content)
    else:
        updated_content = f"{content}\n\n## Solutions\n{replacement}"

    README_PATH.write_text(updated_content, encoding="utf-8")
    print("README.md indexing system successfully updated!")


if __name__ == "__main__":
    data = get_solutions_data()
    md_tables = build_markdown_tables(data)
    update_readme(md_tables)
