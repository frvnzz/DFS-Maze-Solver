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

        public bool Solve() => DFS(start.Item1, start.Item2);

        private bool DFS(int x, int y)
        {
            if (x < 0 || y < 0 || x >= maze.Rows || y >= maze.Cols || maze.Grid[x, y] == 1 || visited[x, y])
                return false;

            visited[x, y] = true;
            path.Add((x, y));

            if ((x, y) == end)
                return true;

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = { 0, 0, -1, 1 };

            for (int i = 0; i < 4; i++)
            {
                if (DFS(x + dx[i], y + dy[i]))
                    return true;
            }

            path.RemoveAt(path.Count - 1);
            return false;
        }

        public void PrintSolution()
        {
            for (int i = 0; i < maze.Rows; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < maze.Cols; j++)
                {
                    if (maze.Grid[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray; // Walls in gray
                        Console.Write("1");
                    }
                    else if (path.Contains((i, j)))
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Path in green
                        Console.Write("2"); // Representing path as '2'
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White; // Empty spaces in white
                        Console.Write("0");
                    }

                    if (j < maze.Cols - 1) Console.Write(", ");
                }
                Console.WriteLine(" },");
            }
            Console.ResetColor();
        }
    }
}