using System;
/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. Example:
*/
class StringMatrix
{
    static void Main()
    {
        //Uncomment below code to test

        //string[,] matrix =
        //{
        //    {"ivan", "ivan", "ivan"},
        //    {"pesho", "gosho", "misho"},
        //    {"misho", "sasho", "misho"},                 
        //};

        //Uncomment below code to test

        //string[,] matrix =
        //{
        //    {"ivan", "ivan", "misho"},
        //    {"pesho", "gosho", "misho"},                  
        //    {"misho", "sasho", "misho"},
        //};

        //Uncomment below code to test

        //string[,] matrix =
        //{
        //    {"gosho", "ivan", "misho"},
        //    {"pesho", "gosho", "misho"},                  
        //    {"misho", "sasho", "gosho"},
        //};

        //Uncomment below code to test and write your own matrix

        //Console.Write("N=");
        //int n = int.Parse(Console.ReadLine());
        //Console.Write("M=");
        //int m = int.Parse(Console.ReadLine());
        //string[,] matrix = new string[n, m];
        //for (int rows = 0; rows < matrix.GetLength(0); rows++)
        //{
        //    for (int cols = 0; cols < matrix.GetLength(1); cols++)  <-uncomment
        //    {
        //        Console.Write("matrix[{0},{1}]=", rows, cols);
        //        matrix[rows, cols] = Console.ReadLine();
        //    }
        //}

        //default unit test matrix

        string[,] matrix =
        {
            {"gosho", "ivan", "misho", "georgi", "petar", "kiril", "sasho"},
            {"pesho", "gosho", "misho", "desi", "kiril", "sasho", "ivan"},
            {"misho", "sasho", "sasho", "kiril", "petar", "georgi", "ivan"},
        };
        int maxSequenceOfStrings = 1;
        string stringName = "";
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            string firstString = matrix[rows, 0];
            int sequenceCounter = 1;
            for (int cols = 1; cols < matrix.GetLength(1); cols++)
            {
                if (matrix[rows, cols] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rows, cols];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rows, cols];
                }
            }
        }
        for (int cols = 0; cols < matrix.GetLength(1); cols++)
        {
            string firstString = matrix[0, cols];
            int sequenceCounter = 1;
            for (int rows = 1; rows < matrix.GetLength(0); rows++)
            {
                if (matrix[rows, cols] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rows, cols];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rows, cols];
                }
            }
        }
        for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
        {
            int cols = 1;
            int rowCounter = rows + 1;
            string firstString = matrix[rows, 0];
            int sequenceCounter = 1;
            while ((rowCounter < matrix.GetLength(0)) && (cols < matrix.GetLength(1)))
            {
                if (matrix[rowCounter, cols] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rowCounter, cols];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rowCounter, cols];
                }
                rowCounter++;
                cols++;
            }
        }
        for (int cols = 1; cols < matrix.GetLength(1); cols++)
        {
            int rows = 1;
            int colCounter = cols + 1;
            string firstString = matrix[0, cols];
            int sequenceCounter = 1;
            while ((rows < matrix.GetLength(0)) && (colCounter < matrix.GetLength(1)))
            {
                if (matrix[rows, colCounter] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rows, colCounter];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rows, colCounter];
                }
                colCounter++;
                rows++;
            }
        }
        for (int rows = matrix.GetLength(0) - 1; rows >= 0; rows--)
        {
            int cols = matrix.GetLength(1) - 2;
            int rowCounter = rows + 1;
            string firstString = matrix[rows, matrix.GetLength(1) - 1];
            int sequenceCounter = 1;
            while ((rowCounter < matrix.GetLength(0)) && (cols < matrix.GetLength(1)) && rows >= 0 && rowCounter >= 0)
            {
                if (matrix[rowCounter, cols] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rowCounter, cols];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rowCounter, cols];
                }
                rowCounter++;
                cols--;
            }
        }
        for (int cols = matrix.GetLength(1) - 2; cols >= 0; cols--)
        {
            int rows = 1;
            int colCounter = cols - 1;
            string firstString = matrix[0, cols];
            int sequenceCounter = 1;
            while ((rows < matrix.GetLength(0)) && (colCounter < matrix.GetLength(1)) && rows >= 0 && colCounter >= 0)
            {
                if (matrix[rows, colCounter] == firstString)
                {
                    sequenceCounter += 1;
                    if (sequenceCounter > maxSequenceOfStrings)
                    {
                        maxSequenceOfStrings = sequenceCounter;
                        stringName = matrix[rows, colCounter];
                    }
                }
                else
                {
                    sequenceCounter = 1;
                    firstString = matrix[rows, colCounter];
                }
                colCounter--;
                rows++;
            }
        }
        for (int i = 0; i < maxSequenceOfStrings; i++)
        {
            if (i != maxSequenceOfStrings - 1)
            {
                Console.Write("{0}, ", stringName);
            }
            else
            {
                Console.WriteLine(stringName);
            }
        }
    }
}
