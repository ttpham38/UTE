using System;

class DeleteItem
{
    static int CountArr(int[] arr, int key)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != key)
            {
                count++;
            }
        }
        return count;
    }
    static int[] ReplaceItem(int[] arr, int key)
    {
        int[] newArr = new int[CountArr(arr, key)];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != key)
            {
                newArr[j] = arr[i];
                j++;
            }
        }
        return newArr;
    }
    static void Main()
    {
        int[] arr = { 4, 2, 6, 8, 2, 5, 3, 8, 7, 3, 8 };
        int key;
        Console.Write("Nhap vao so can xoa: ");
        key = int.Parse(Console.ReadLine());
        Console.WriteLine($"Mang truoc khi xoa: {String.Join(", ", arr)}");
        Console.WriteLine($"Mang sau khi xoa: {String.Join(", ", ReplaceItem(arr, key))}");
    }
}
