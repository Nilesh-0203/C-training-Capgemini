// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n=0;
        bool flag=false;
        while(!flag){
            try{
                Console.WriteLine ("Welcome to Calculator : ");
            Console.WriteLine ("Enter the 1 for Calculation : ");
            Console.WriteLine ("Enter the 2 for exit : ");
            n=Convert.ToInt32(Console.ReadLine());
            flag=true;
            if(flag && n==1){
                Console.WriteLine ("Enter the number1 : ");
                double num1=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine ("Enter the number2 : ");
                double num2=Convert.ToDouble(Console.ReadLine());
                
                Console.WriteLine ("Enter the operator : ");
                char ch=Console.ReadKey().KeyChar;
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
                  flag=false;
               }
            }
            catch(Exception e){
                flag=false;
            }
            }
        }
    }
