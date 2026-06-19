using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 25, 30, 45, 50, 60 };

        var result =
            from n in numbers
            where n > 30
            select n;

        Console.WriteLine("Numbers Greater Than 30:");

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        var methodSyntax = numbers.Where(x => x > 30);

        Console.WriteLine("Using Method Syntax:");

        foreach (var item in methodSyntax)
        {
            Console.WriteLine(item);
        }
    }
}