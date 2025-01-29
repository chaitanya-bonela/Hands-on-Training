using System;
class Handson
{
   public static void SortingArray(int[] arr)
    {      
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {           
                int temp = arr[i];
                arr[i] = arr[index];
                arr[index] = temp;
                index++;
            }
        }  
        Array.Sort(arr, 0, index);
    }
    public static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Main()
    {
        int[] arr = { 1,2,0,4,3,0,5,0 };
        //int[] arr = { 30,20,10};
        //int[] arr = { 0,0 };

        Console.WriteLine("Given Array:");
        PrintArray(arr);
        SortingArray(arr);

        Console.WriteLine("Sorted Array :");
        PrintArray(arr);
    }
}