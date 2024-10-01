# squares-solver

An efficient solver for the word puzzles on squares.org, demonstrating algorithmic problem-solving skills and practical application of C#.

# Introduction

As a coding enthusiast, I enjoy tackling challenging puzzles by developing custom solvers. This project is a solver for the puzzles found on squares.org, where the objective is to identify words within a 4x4 grid of letters. The words must be formed by connecting adjacent letters (horizontally, vertically, or diagonally) without reusing any letter in the same word.

The core logic of this solver is implemented using a recursive backtracking algorithm (although I may consider revisiting this and using a stack based approach in future). The program iterates through all words in a given dictionary (in this case, the Scrabble SOWPODS dictionary) and uses the Solver class to verify each word's validity in the grid. The class efficiently handles duplicate letters by finding all possible starting points and recursively exploring adjacent cells, storing visited points in a HashSet to prevent reuse and backtracking to explore alternative paths if necessary. This approach ensures that the algorithm accurately identifies all valid words in the grid.

# Unit Tests

The project includes basic unit tests that demonstrate the core functionality and usage of the Solver class. While the current tests cover fundamental cases, there is room for expansion to include more complex scenarios, ensuring comprehensive validation of the algorithm's robustness.