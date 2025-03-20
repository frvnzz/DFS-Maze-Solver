## DFS-Maze-Solver

<p align="center">
  <img width="400" src="/docs/Depth-First-Search.gif">
</p> 

This program solves a Maze (2D integer array with 1 = wall and 0 = paths) using the Depth-first search algorithm.

### Built With

- **C#**
- **.NET 8.0 SDK** for development and execution/compilation

## Getting Started

To get started with the DFS Maze Solver, follow the steps below to install and run the program.

### Prerequisites

Before running the program, ensure that you have the following installed:

- **[.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**

### Installation

1. Clone the repository or download the source code from [here](https://github.com/frvnzz/DFS-Maze-Solver/archive/refs/heads/main.zip):

   ```bash
   git clone https://github.com/frvnzz/DFS-Maze-Solver.git
   cd DFS-Maze-Solver/DFSApplication
   ```

2. Generate a maze and specify it in `/DFSAlgorithm/Maze.cs`. I found ChatGPT very helpful to generate mazes with this prompt:

   ```
    Give me a 10x10 maze. Follow these constraints:

    Walls are represented by 1, and open paths by 0.
    There must be EXACTLY TWO openings (0) along the outer border (first or last column or row): one entry and one exit.
    The entry and exit positions must be random, but always located somewhere on the border (first or last row/column).
    The maze must be solvable, with at ONE CONTINUOUS path (0) from the entry to the exit.
    The maze should include many false paths and dead ends to make it more challenging.
    No diagonal movement is allowed, only horizontal and vertical movement.
    The maze should resemble a classic labyrinth.
    Format the maze as a C# integer 2D array.
   ```

3. Run the program using one of the following command:

    ```bash
   dotnet run
   ```

### Usage

(show useful examples of how a project can be used)

## Roadmap

(what have been implemented and what are the planed features.)

## Contributing

(encourage people to work on your project)

## License

Distributed under the Unlicense License. See `/docs/LICENSE` for more information.

## Contact

Franz-Aurel Huber – [cc231014@fhstp.ac.at](mailto:cc231014@fhstp.ac.at)

## Acknowledgments

*Depth-first search Animation  
`/docs/Depth-First-Search.gif`  
Source: [Wikimedia Commons](https://commons.wikimedia.org/wiki/File:Depth-First-Search.gif), licensed under the [Creative Commons](https://en.wikipedia.org/wiki/Creative_Commons) Attribution-Share Alike [3.0 Unported](https://creativecommons.org/licenses/by-sa/3.0/deed.en), [2.5 Generic](https://creativecommons.org/licenses/by-sa/2.5/deed.en), [2.0 Generic](https://creativecommons.org/licenses/by-sa/2.0/deed.en) and [1.0 Generic](https://creativecommons.org/licenses/by-sa/1.0/deed.en) license.*