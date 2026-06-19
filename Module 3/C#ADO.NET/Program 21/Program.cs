using System;

class Program
{
    static string CheckNumber(object value)
    {
        return value switch
        {
            int n when n > 0 => "Positive Number",
            int n when n < 0 => "Negative Number",
            int => "Zero",
            _ => "Not a Number"
        };
    }

    static void Main()
    {
        Console.WriteLine(CheckNumber(10));
        Console.WriteLine(CheckNumber(-5));
        Console.WriteLine(CheckNumber(0));
        Console.WriteLine(CheckNumber("Hello"));
    }
}