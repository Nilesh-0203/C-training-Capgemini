// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
    
        int e=0;
        
        while(e==0){
                Console.WriteLine ("Enter the number1 : ");
                double num1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine ("Enter the number2 : ");
                double num2=Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine ("Enter the operator : ");
                char ch=Convert.ToChar(Console.ReadLine());
                Console.WriteLine ();
                switch (ch){
                    case '+':
                    Console.WriteLine ($"Addition of {num1} and {num2} is {num1+num2}");
                    break;
                    
                    case '-':
                    Console.WriteLine ($"Subtraction of {num1} and {num2} is {num1-num2}");
                    break;
                    
                    case '*':
                    Console.WriteLine ($"Multiplication of {num1} and {num2} is {num1*num2}");
                    break;
                    
                    case '/':
                    Console.WriteLine ($"Division of {num1} and {num2} is {num1/num2}");
                    break;
                    
                    default:
                    Console.WriteLine ("Enter Wrong Input");
                    break;
                  }
            Console.WriteLine ("Enter the 1 for Calculation : ");
            Console.WriteLine ("Enter the 2 for exit : ");
            int c=Convert.ToInt32(Console.ReadLine());
            if(c==1)e=0;
            else e=1;
            }
        }
    }
