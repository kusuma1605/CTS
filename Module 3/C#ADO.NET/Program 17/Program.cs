using System;

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = null;

        Console.WriteLine(s?.Name);

        string result = s?.Name ?? "No Name Available";

        Console.WriteLine(result);
    }
}