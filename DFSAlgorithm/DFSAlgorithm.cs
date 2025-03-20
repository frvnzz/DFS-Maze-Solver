using System;
using System.Collections.Generic;

namespace DFSAlgorithm
{
    public class DFSAlgorithm
    {
        private readonly Maze maze;
        private readonly (int, int) start, end;
        private readonly List<(int, int)> path = new();
        private readonly bool[,] visited;

        public DFSAlgorithm(Maze maze, (int, int) start, (int, int) end)
        {
            this.maze = maze;
            this.start = start;
            this.end = end;
            this.visited = new bool[maze.Rows, maze.Cols];
        }

        // Returns true if a solution is found, false otherwise
        public bool Solve() => DFS(start.Item1, start.Item2);

        // True if path is found, false otherwise
        private bool DFS(int x, int y)
        {
            // Check for out of bounds, walls, and visited cells
            if (x < 0 || y < 0 || x >= maze.Rows || y >= maze.Cols || maze.Grid[x, y] == 1 || visited[x, y])
                return false;

            // Mark the cell as visited and add it to the path
            visited[x, y] = true;
            path.Add((x, y));

            // Check if the end point is reached
            if ((x, y) == end)
                return true;

            // Array of possible moves (directions)
            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            // Recursively check all four possible moves
            for (int i = 0; i < 4; i++)
            {
                if (DFS(x + dx[i], y + dy[i]))
                    return true;
            }

            // If no solution is found, backtrack (-1)
            path.RemoveAt(path.Count - 1);
            visited[x, y] = false;
            return false;
        }

        public List<(int, int)> GetPath() => path;
    }
}