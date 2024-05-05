using System;
using System.Collections.Generic;

class linearSearch
{
    static List<int> FindAllOccurrences(int[] arr, int x)
    {
        List<int> occurrences = new List<int>();
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == x)
                occurrences.Add(i);
        }
        return occurrences;
    }
    public static void Main()
    {
        int[] arr = [2, 3, 4, 10, 40, 10];
        int x = 10;
        List<int> result = FindAllOccurrences(arr, x);
        if (result.Count == 0)
            Console.WriteLine("Khong tim thay");
        else
        {
            Console.WriteLine("Phan tu tim thay duoc tai cac vi tri: ");
            foreach (int index in result)
            {
                Console.WriteLine(index);
            }
        }
    }
}