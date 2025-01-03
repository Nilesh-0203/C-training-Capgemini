// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the number : ");
        int n=Convert.ToInt32(Console.ReadLine());
        int sum=(n/2)*(2+(n-1)*2);
        Console.WriteLine ($"The Sum of odd Natural Number upto {n} terms : {sum} ");
    }
}
