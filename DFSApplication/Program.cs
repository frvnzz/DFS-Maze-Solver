using System;
using DFSAlgorithm;

namespace DFSApplication
{
    class Program
    {
        static void Main()
        {
            var maze = new Maze();
            var start = maze.FindStartPoint(); // Find the start point dynamically
            var end = maze.FindEndPoint(); // Find the endpoint dynamically

            if (start == (-1, -1) || end == (-1, -1))
            {
                Console.WriteLine("No valid start or end point found.");
                return;
            }

            var solver = new DFSAlgorithm.DFSAlgorithm(maze, start, end);

            if (solver.Solve())
                MazePrinter.PrintSolution(maze, solver.GetPath());
            else
                Console.WriteLine("No solution found.");
        }
    }
}