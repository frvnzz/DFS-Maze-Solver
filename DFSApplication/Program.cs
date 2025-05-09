﻿using System;
using DFSAlgorithm;

namespace DFSApplication
{
    class Program
    {
        static void Main()
        {
            var maze = new Maze();
            var start = maze.FindStartPoint(); // find the start point (from Maze.cs)
            var end = maze.FindEndPoint(); // find the endpoint (from Maze.cs)

            // if no valid start or end point found (from Maze.cs), print a message and return
            if (start == (-1, -1) || end == (-1, -1))
            {
                Console.WriteLine("No valid start or end point found.");
                return;
            }

            // solve the maze using the algorithm defined in DFSAlogrithm.cs
            var solver = new DFSAlgorithm.DFSAlgorithm(maze, start, end);

            if (solver.Solve())
                MazePrinter.PrintSolution(maze, solver.GetPath());
            else
                Console.WriteLine("No solution found.");
        }
    }
}