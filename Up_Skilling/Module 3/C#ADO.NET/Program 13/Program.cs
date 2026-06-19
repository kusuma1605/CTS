using System;

public record Person
{
    public string Name { get; init; }
    public int Age { get; init; }
}

class Program
{
    static void Main()
    {
        Person p = new Person
        {
            Name = "Kusuma",
            Age = 21
        };

        Console.WriteLine(p);
    }
}