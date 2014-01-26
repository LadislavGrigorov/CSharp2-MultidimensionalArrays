using System;
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
class SortIntegerArray
{
    static void Main()
    {
        Console.Write("N=");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K=");
        int k = int.Parse(Console.ReadLine());
        int[] arrOfInts = new int[n];
        for (int i = 0; i < arrOfInts.Length; i++)
        {
            Console.Write("number[{0}]=",i);
            arrOfInts[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arrOfInts);
        int p = Array.BinarySearch(arrOfInts, k);
        if (k>=arrOfInts[0])
        {
            while (p < 0)
            {
                k--;
                p = Array.BinarySearch(arrOfInts, k);
            }
            Console.WriteLine("Number[{0}] is smaller or equal to K", p);
        }
        else
        {
            Console.WriteLine("There isnt smaller number than k");
        }
        
        //foreach (int number in arrOfInts)
        //{
        //    Console.WriteLine(number);
        //}
    }
}
