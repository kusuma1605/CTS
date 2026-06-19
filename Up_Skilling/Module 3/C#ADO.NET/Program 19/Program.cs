using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> eventsList = new List<string>()
        {
            "Music",
            "Sports",
            "Dance"
        };

        foreach (string item in eventsList)
        {
            Console.WriteLine(item);
        }

        Dictionary<int, string> dict = new Dictionary<int, string>();

        dict.Add(1, "Music");
        dict.Add(2, "Sports");

        foreach (var item in dict)
        {
            Console.WriteLine(item.Key + " " + item.Value);
        }
    }
}