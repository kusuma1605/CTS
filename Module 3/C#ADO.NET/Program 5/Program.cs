using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        if (score >= 90)
            Console.WriteLine("Grade A");
        else if (score >= 75)
            Console.WriteLine("Grade B");
        else if (score >= 60)
            Console.WriteLine("Grade C");
        else
            Console.WriteLine("Fail");

        string result = score switch
        {
            >= 90 => "A",
            >= 75 => "B",
            >= 60 => "C",
            _ => "Fail"
        };

        Console.WriteLine("Using switch: " + result);
    }
}