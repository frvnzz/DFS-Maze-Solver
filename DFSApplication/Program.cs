using System;
using DFSAlgorithm;

namespace DFSApplication
{
    class Program
    {
        static void Main()
        {
            var maze = new Maze();
            var solver = new DFSAlgorithm.DFSAlgorithm(maze, (0, 0), (4, 4));

            if (solver.Solve())
                solver.PrintSolution();
            else
                Console.WriteLine("No solution found.");
        }
    }
}