using System;

class BinarySearch
{
    static int FuncBinarySearch(int[] arr, int key)
    {
        int left = 0;
        int right = arr.Length - 1;
        int mid = 0;
        int steps = 0;

        while (left <= right)
        {
            mid = (left + right) / 2;
            if (arr[mid] == key)
            {
                return steps;
            }
            else if (arr[mid] > key)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
            steps++;
            Console.WriteLine($"Step: {steps}");
            Console.WriteLine($"Array: {string.Join(", ", arr.Skip(left).Take(right - left + 1))}");
        }
        return steps;
    }
    static void Main()
    {
        int[] arr = [2, 3, 4, 10, 20, 22, 33, 40, 60, 89, 90, 125, 267, 299, 312, 355, 453];
        int x = 2;
        Console.WriteLine($"Total Steps: {FuncBinarySearch(arr, x)}");
    }
}