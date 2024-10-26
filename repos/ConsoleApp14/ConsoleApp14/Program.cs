using System;
class floydstriangle
{
    public static void Main(String[] args)
    {
        int count = 1;
        Console.WriteLine("Enter the number of rows:");
        int height = Convert.ToInt32(Console.ReadLine());
        long[][] triangle = new long[height][];
        for (int row = 0; row < height; row++)
        {
            triangle[row] = new long[row + 1];
        }
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                triangle[row][col] = count++;
            }
        }
        for (int row = 0; row < height; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write(triangle[row][col]+" ");
            }
            Console.WriteLine(" ");
        }
    }
}



