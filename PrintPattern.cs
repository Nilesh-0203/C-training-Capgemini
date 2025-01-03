// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        for(int i=1;i<=n;i++){
            for(int j=1;j<=i;j++){
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
