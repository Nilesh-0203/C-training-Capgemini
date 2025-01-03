// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class Student
{
    string name;
    int age;
    char grade;
    public Student(string name, int age, char grade)
    {
        this.name = name;
        this.age = age;
        this.grade = grade;
    }

    public string getName()
    {
        return name;
    }
    public int getAge()
    {
        return age;
    }
    public char getgrade()
    {
        return grade;
    }
    public string toString()
    {
        return "Name of Student : " + this.getName() + " \nAge of Student : " + this.getAge()
            + " \nStudent Grade : " + this.getgrade();
    }
    public static void Main(string[] args)
    {
        Student s1 = new Student("Nilesh", 22, 'A');
        Console.WriteLine(s1.toString());
    }
}
