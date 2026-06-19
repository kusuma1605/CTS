using System;

class Employee
{
    public required string Name { get; set; }
    public required int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee
        {
            Name = "Kusuma",
            Age = 21
        };

        Console.WriteLine($"{e.Name} {e.Age}");
    }
}