using System;

class Student
{
    public string Name;
}

class Program
{
    static void ChangeValue(int x)
    {
        x = 100;
    }

    static void ChangeReference(Student s)
    {
        s.Name = "Changed Name";
    }

    static void Main()
    {
        int num = 10;

        Student student = new Student();
        student.Name = "Kusuma";

        Console.WriteLine("Before value type: " + num);
        ChangeValue(num);
        Console.WriteLine("After value type: " + num);

        Console.WriteLine("Before reference type: " + student.Name);
        ChangeReference(student);
        Console.WriteLine("After reference type: " + student.Name);
    }
}