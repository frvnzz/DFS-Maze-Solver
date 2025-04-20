using System;
using System.Collections.Generic;

namespace DFSAlgorithm
{
    // Defines the console output for the solution of the maze (colors)
    public class MazePrinter
    {
        public static void PrintSolution(Maze maze, List<(int, int)> path)
        {
            for (int i = 0; i < maze.Rows; i++)
            {
                Console.Write("{ ");
                for (int j = 0; j < maze.Cols; j++)
                {
                    if (maze.Grid[i, j] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray; // walls in gray
                        Console.Write("1");
                    }
                    else if (path.Contains((i, j)))
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // followed path in green
                        Console.Write("2"); // representing the path as 2
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White; // empty spaces in white
                        Console.Write("0");
                    }

                    if (j < maze.Cols - 1) Console.Write(", ");
                }
                Console.WriteLine(" }");
            }
            Console.ResetColor();
        }
    }
}