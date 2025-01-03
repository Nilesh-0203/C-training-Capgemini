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
        int sum=0;
        for(int i=0;i<n;i++){
            sum+=arr[i];
        }
        Console.WriteLine ("The Sum of array is "+ sum);
    }
}
