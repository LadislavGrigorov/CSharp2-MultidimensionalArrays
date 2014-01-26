using System;
//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
class SortArrayOfStrings
{
    private static void SortDescending(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            string maxString = stringArray[i];
            int maxStringPosition = i;
            string temp = "";
            for (int k = i; k < stringArray.Length; k++)
            {
                if (maxString.Length <= stringArray[k].Length)
                {
                    maxString = stringArray[k];
                    maxStringPosition = k;
                }
            }
            temp = stringArray[i];
            stringArray[i] = maxString;
            stringArray[maxStringPosition] = temp;
        }
    }

    private static void SortAscending(string[] stringArray)
    {
        for (int i = 0; i < stringArray.Length; i++)
        {
            string minString = stringArray[i];
            int minStringPosition = i;
            string temp = "";
            for (int k = i; k < stringArray.Length; k++)
            {
                if (minString.Length >= stringArray[k].Length)
                {
                    minString = stringArray[k];
                   minStringPosition = k;
                }
            }
            temp = stringArray[i];
            stringArray[i] = minString;
            stringArray[minStringPosition] = temp;
        }
    }
    private static void PrintArray(string[] stringArray)
    {
        foreach (string randomString in stringArray)
        {
            Console.WriteLine(randomString);
        }
    }
    static void Main()
    {
        string[] stringArray = {"kiro", "rangel", "pesho", "dinko", "asq", "hristofor", "kolumb", "da", "ko", "ne", "koga!?"};
        Console.WriteLine("Enter 1 for ascending sort or 2 for descending sort");
        string n = Console.ReadLine();
        switch (n)
        {
            case "1":
                SortAscending(stringArray);
                PrintArray(stringArray);
                break;
            case "2":
                SortDescending(stringArray);
                PrintArray(stringArray);
                break;
            default:
                Console.WriteLine("Enter 1 or 2!");
                break;
        }  
    }
}
