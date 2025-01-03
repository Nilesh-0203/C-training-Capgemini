// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the String : ");
        string s=Console.ReadLine();
        string ans="";
        if(s.Length<3){
             ans=String.Concat(s,s,s);
        }
        else{
            string temp=s.Substring(0,3);
             ans=String.Concat(temp,s,temp);
        }
        Console.WriteLine(ans);
    }
}
