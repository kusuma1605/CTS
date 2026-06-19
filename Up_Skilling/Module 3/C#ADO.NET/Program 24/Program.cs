using System;
using System.Text.Json;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        Student s = new Student
        {
            Name = "Kusuma",
            Age = 21
        };

        string json = JsonSerializer.Serialize(s);

        Console.WriteLine(json);

        Student obj =
            JsonSerializer.Deserialize<Student>(json);

        Console.WriteLine(obj.Name);
        Console.WriteLine(obj.Age);
    }
}