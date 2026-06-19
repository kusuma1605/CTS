using System;

class Employee
{
    private string name = "Kusuma";

    public void Display()
    {
        Console.WriteLine("Employee Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee();
        emp.Display();
    }
}