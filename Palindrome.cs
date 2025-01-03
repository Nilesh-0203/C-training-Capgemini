// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Enter the String : ");
        string s=Console.ReadLine();
        int i=0;int j=Convert.ToInt32((s.Length))-1;
        bool flag=true;
        while(i<j){
            if(s[i]!=s[j]){
                flag=false;
                break;
            }
            i++;
            j--;
        }
        if(flag==true){
            Console.WriteLine ("String is Palindrome");
        }
        else{
            Console.WriteLine ("String is not Palindrome");
        }
    }
}
