# Copilot Instructions for AI Coding Agents

## Project Overview
This repository is based on Josee9988's GitHub Project Template. It is structured for shell-based automation and project scaffolding, with a focus on maintainability and developer onboarding.

## Key Components
- `SETUP_TEMPLATE.sh`: Main entrypoint script for customizing the project after cloning. It updates project metadata and personalizes files. Run this script immediately after cloning.
- `bin/FUNCTION_HELPERS.sh`: Contains helper functions used by the main setup script for modularity.
- `tests/`: Contains all test scripts, including unit tests for the setup process. Uses `shunit2` for shell-based unit testing.
- `CHANGELOG.md`, `README.md`, and `.github/`: Documentation and community health files, auto-populated and customizable via the setup script.

## Developer Workflows
- **Setup:** After cloning, run `bash SETUP_TEMPLATE.sh` (or `./SETUP_TEMPLATE.sh`). On Windows, use Git Bash.
- **Testing:** Run all tests with `bash tests/TESTS_RUNNER.sh`. This script aggregates all unit tests and returns exit code 0 for success, 1 for failure.
- **Customization:** After running the setup script, manually review and update all files for project-specific needs.

## Project-Specific Conventions
- All shell scripts are modularized; helpers are placed in `bin/` and sourced as needed.
- Tests are organized by feature (argument parsing, custom data, scaffolding) and use `shunit2`.
- Markdown files follow [MarkdownLint](https://github.com/DavidAnson/markdownlint) rules.
- Issue templates, labels, and bots are pre-configured in `.github/` for streamlined community management.

## Integration Points
- **GitHub Bots:** Issue label bot, settings bot, welcome bot, and to-do bot are supported via config files in `.github/`.
- **External Dependencies:** `shunit2` for shell testing (included in `tests/`).

## Examples
- To run all tests: `bash tests/TESTS_RUNNER.sh`
- To customize project metadata: `bash SETUP_TEMPLATE.sh --username=yourname --projectName=yourproject`

## References
- See `README.md` for template usage and setup details.
- See `bin/README.md` and `tests/README.md` for script and test organization.

---

> After updating this file, review for accuracy and completeness. If any conventions or workflows are unclear, provide feedback for further iteration.
