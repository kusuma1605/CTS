using System;

abstract class Shape
{
    public abstract double Area();
}

interface IDraw
{
    void Draw();
}

class Circle : Shape, IDraw
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return 3.14 * Radius * Radius;
    }

    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}

class Program
{
    static void Main()
    {
        Circle c = new Circle(5);

        Console.WriteLine("Area = " + c.Area());

        c.Draw();
    }
}