using System;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Kusuma",
            Age = 21
        };

        Console.WriteLine($"Name: {s.Name}");
        Console.WriteLine($"Age: {s.Age}");
    }
}