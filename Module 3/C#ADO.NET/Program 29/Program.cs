using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input =
            "<script>alert('XSS')</script>";

        string safeInput =
            WebUtility.HtmlEncode(input);

        Console.WriteLine("Original:");
        Console.WriteLine(input);

        Console.WriteLine("Encoded:");
        Console.WriteLine(safeInput);
    }
}