# Assignment1 Report

Course: C# Development SS2025 (4 ECTS, 3 SWS)

Student ID: cc231014

BCC Group: A

Name: Franz-Aurel Huber

## Methodology:

1. **Maze Representation**:
   - The maze is represented as a 2D integer array where:
     - `1` represents walls.
     - `0` represents open paths.
   - The maze is defined in the `Maze` class, which also includes methods to dynamically detect the start and end points.

2. **Dynamic Start and End Detection**:
   - The `FindStartPoint` method identifies the first open cell (`0`) in the maze as the starting point.
   - The `FindEndPoint` method identifies the last open cell (`0`) on the border of the maze as the endpoint.

3. **Depth-First Search Algorithm**:
   - The `DFSAlgorithm` class implements the Depth-First Search (DFS) algorithm to solve the maze.
   - The algorithm recursively explores all possible paths from the start point to the endpoint.
   - It uses a `visited` array to avoid revisiting cells and backtracks when encountering dead ends.

4. **Path Visualization**:
   - The `MazePrinter` class outputs the maze and the solution path to the console.
   - The solution path is color-coded for better readability:
     - Walls (`1`) are displayed in gray.
     - Open paths (`0`) are displayed in white.
     - The solution path (`2`) is displayed in green.

5. **Execution**:
   - The `Program` class initializes the maze, detects the start and end points, and invokes the DFS algorithm to solve the maze.
   - If a solution is found, the solution path is printed to the console. Otherwise, an error message is displayed.

## Additional Features
Correct path visualization in the console through `/DFSAlgorithm/MazePrinter.cs`

## Discussion/Conclusion
### Challenges Faced
1. **Dynamic start and end detection**
2. **Path visualization in the console**: Outputting the correct path in an understandable way without a GUI.

### Future Improvements
- A graphical user interface
- Handling multiple entry/exit points
- Importing an image of a maze that has to be solved

## Work with: 
/

## Reference: 
### Websites:
[Depth-first search – Wikipedia](https://en.wikipedia.org/wiki/Depth-first_search)
[Depth First Search (DFS) – Programiz](https://www.programiz.com/dsa/graph-dfs)
[Depth-First Search (DFS) Algorithm – Medium](https://medium.com/@that-software-PM/depth-first-search-dfs-algorithm-201dc95e524)

### Videos:
[Depth-first search in 4 minutes](https://www.youtube.com/watch?v=Urx87-NMm6c)
[Depth First Search Algorithm | Graph Theory](https://www.youtube.com/watch?v=7fujbpJ0LB4)
[Path-finding Visualization Comparison; A*, Dijkstra, BFS and DFS](https://www.youtube.com/watch?v=aW9kZcJx64o)
[Depth First Search (DFS) Explained - Visual](https://www.youtube.com/watch?v=VTAZ3lPOllA)