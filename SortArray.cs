// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the size of array : ");
        int n=Convert.ToInt32(Console.ReadLine());
        
        int[] arr=new int[n];
        for(int i=0;i<n;i++){
            Console.WriteLine ("Enter the "+i+" Element");
            arr[i]=Convert.ToInt16(Console.ReadLine());
        }
        bool swapped;
        for (int i = 0; i < n - 1; i++) {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (swapped == false)
                break;
        }
        Console.WriteLine ("Sorrted array");
        for(int i=0;i<n;i++){
            Console.Write (arr[i]+" ");
        }
    }
}
