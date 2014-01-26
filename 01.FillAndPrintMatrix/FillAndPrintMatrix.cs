using System;
//Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

class FillAndPrintMatrix
{
    static void FillMatrixA(int[,] matrix)
    {
        int number = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = number;
                number++;
            }
        }
    }
    static void FillMatrixB(int[,] matrix)
    {
        int number = 1;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
    }
    static void FillMatrixC(int[,] matrix)
    {
        int number = 1;
        for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
        {
            int col = 0;
            int rowCounter = row;
            while ((rowCounter<matrix.GetLength(0)) && (col<matrix.GetLength(1)))
            {
                matrix[rowCounter, col] = number;
                rowCounter++;
                col++; 
                number++;
            }
        }
        for (int col = 1; col < matrix.GetLength(1); col++)
        {
            int row = 0;
            int colCounter = col;
            while ((row < matrix.GetLength(0)) && (colCounter < matrix.GetLength(1)))
            {
                matrix[row, colCounter] = number;
                colCounter++;
                row++;
                number++;
            }
        }
    }
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-6}",matrix[row, col] + "   ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter size of matrix [n, n]: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        Console.WriteLine("Choose how to fill the matrix. ");
        Console.WriteLine("Enter a, b or c:");
        char usersChoice = char.Parse(Console.ReadLine());
        switch (usersChoice)
        {
            case 'a':
                FillMatrixA(matrix);
                break;
            case 'b':
                FillMatrixB(matrix);
                break;
            case 'c':
                FillMatrixC(matrix);
                break;
        }
        PrintMatrix(matrix);
    }
}