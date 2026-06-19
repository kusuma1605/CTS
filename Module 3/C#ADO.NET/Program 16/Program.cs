using System;

class Program
{
    static void Main()
    {
        string name = null;

        try
        {
            Console.WriteLine(name.Length);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("Null Reference Exception Caught");
        }
    }
}