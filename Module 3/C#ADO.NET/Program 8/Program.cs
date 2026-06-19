using System;

class Program
{
    static void RefMethod(ref int x)
    {
        x = x + 10;
    }

    static void OutMethod(out int y)
    {
        y = 50;
    }

    static void InMethod(in int z)
    {
        Console.WriteLine("In parameter value: " + z);
    }

    static void Main()
    {
        int a = 10;
        Console.WriteLine("Before ref: " + a);
        RefMethod(ref a);
        Console.WriteLine("After ref: " + a);

        int b;
        OutMethod(out b);
        Console.WriteLine("Out value: " + b);

        int c = 100;
        InMethod(in c);
    }
}