public class Grid
{
    public int X { get; set; }
    public int Y { get; set; }
    public int[,] Matrix { get; set; }

    public Grid(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static int[,] CreateGrid(int SizeX, int SizeY, int[,] Matrix)
    {
        int sizeX = SizeX;
        int sizeY = SizeY;
        Matrix = new int[sizeX, sizeY];

        return Matrix;
    }

    public static void Print(int x, int y, int[,] matrix)
    {

        for (int row = 0; row < x; row++) //loop x
        {
            for (int col = 0; col < y; col++) //loop y
            {
                if (matrix[row, col] == 0)
                {
                    Console.Write(" ");
                }
                else if (matrix[row, col] == 1)
                {
                    Console.Write("T");
                }
                else if (matrix[row, col] == 2)
                {
                    Console.Write("P");
                }
                else if (matrix[row, col] == 3)
                {
                    Console.Write("C");
                }

            }
            Console.WriteLine();
        }

    }
}