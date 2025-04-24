public class Maze
{
    public int[,] Grid { get; }
    public int Rows => Grid.GetLength(0);
    public int Cols => Grid.GetLength(1);

    // 0 = path, 1 = wall
    public Maze()
    {
        // DEFINE YOUR MAZE HERE
        Grid = new int[,]
        {
            { 1, 0, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 0, 1, 0, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 1, 0, 0 },
            { 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 1, 0, 0, 0, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
        };
    }

    // the first open cell (0) will be the start point
    public (int, int) FindStartPoint()
    {
        // loop through all rows and columns to find the first 0
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                // if the cell is 0, return its coordinates
                if (Grid[i, j] == 0)
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1); // if no valid start point is found
    }

    // endpoints are the last row or column with a 0
    public (int, int) FindEndPoint()
    {
        // loop through all rows and columns to find the last 0
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                // if the cell is 0, return its coordinates
                if (Grid[i, j] == 0 && (i == Rows - 1 || j == Cols - 1))
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1); // if no valid end point is found
    }
}