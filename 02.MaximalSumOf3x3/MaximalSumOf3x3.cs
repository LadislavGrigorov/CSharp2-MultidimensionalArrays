using System;
//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                matrix[rows, cols] = int.Parse(Console.ReadLine());
            }
        }
        for (int rows = 0; rows < n; rows++)
        {
            for (int cols = 0; cols < m; cols++)
            {
                Console.Write("{0,-6}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        int maxSum = 0;
        int maxSumRow = 0;
        int maxSumCol = 0;
        for (int rows = 0; rows < n - 2; rows++)
        {
            for (int cols = 0; cols < m - 2; cols++)
            {
                int sum =0;
                for (int innerRows = 0; innerRows < 3; innerRows++)
                {
                    for (int innerCols = 0; innerCols < 3; innerCols++)
                    {
                        sum += matrix[(rows + innerRows), (cols + innerCols)];
                    }
                }
                if (sum >= maxSum)
                {
                    maxSum = sum;
                    maxSumRow = rows;
                    maxSumCol = cols;
                }
            }
        }
        Console.WriteLine("Max sum 3x3 square:");
        for (int rows = maxSumRow; rows < maxSumRow+3; rows++)
        {
            for (int cols = maxSumCol; cols < maxSumCol+3; cols++)
            {
                Console.Write("{0,-6}", matrix[rows, cols]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The total sum is {0}", maxSum);
    }
}
