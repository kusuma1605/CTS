using System;

class Person
{
    public string Name = "Kusuma";
}

class Program
{
    static void Main()
    {
        var number = 10;
        var text = "Hello";
        Person p = new();

        Console.WriteLine(number);
        Console.WriteLine(number.GetType());

        Console.WriteLine(text);
        Console.WriteLine(text.GetType());

        Console.WriteLine(p.Name);
        Console.WriteLine(p.GetType());
    }
}