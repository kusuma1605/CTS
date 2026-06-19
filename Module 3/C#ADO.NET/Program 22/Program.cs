using System;

class Program
{
    static (string, int) GetStudent()
    {
        return ("Kusuma", 21);
    }

    static void Main()
    {
        var student = GetStudent();

        Console.WriteLine("Name: " + student.Item1);
        Console.WriteLine("Age: " + student.Item2);

        var (name, age) = GetStudent();

        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}