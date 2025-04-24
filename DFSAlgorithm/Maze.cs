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

    // The first open cell (0) will be the start point
    public (int, int) FindStartPoint()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (Grid[i, j] == 0)
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1); // if no valid start point is found
    }

    // Endpoints are the last row or column with a 0
    public (int, int) FindEndPoint()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Cols; j++)
            {
                if (Grid[i, j] == 0 && (i == Rows - 1 || j == Cols - 1))
                {
                    return (i, j);
                }
            }
        }
        return (-1, -1); // if no valid end point is found
    }
}