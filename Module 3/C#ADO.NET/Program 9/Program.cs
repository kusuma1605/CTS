using System;

class Program
{
    static int CalculateFactorial(int n)
    {
        int Factorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Factorial(num - 1);
        }

        return Factorial(n);
    }

    static void Main()
    {
        Console.WriteLine("Factorial of 5 is: " + CalculateFactorial(5));
    }
}