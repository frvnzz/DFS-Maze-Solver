public class Maze
{
    public int[,] Grid { get; }
    public int Rows => Grid.GetLength(0);
    public int Cols => Grid.GetLength(1);

    // 0 = path, 1 = wall
    public Maze()
    {
        Grid = new int[,]
        {
            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
            { 0, 0, 1, 0, 0, 0, 1, 0, 0, 1 },
            { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 1, 1, 0, 1, 1, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 0, 0, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 0, 1, 1, 0, 1 },
            { 1, 0, 0, 0, 1, 0, 0, 0, 0, 1 },
            { 1, 0, 1, 0, 0, 0, 1, 1, 0, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 }
        };
    }

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
        return (-1, -1);
    }

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
        return (-1, -1); // No valid endpoint found
    }
}