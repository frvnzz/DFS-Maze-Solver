using System;
using DFSAlgorithm;

namespace DFSApplication
{
    class Program
    {
        static void Main()
        {
            var maze = new Maze();
            var solver = new DFSAlgorithm.DFSAlgorithm(maze, (0, 0), (6, 6));

            if (solver.Solve())
                MazePrinter.PrintSolution(maze, solver.GetPath());
            else
                Console.WriteLine("No solution found.");
        }
    }
}