using System;
using System.Threading;

class Program
{
    static object lock1 = new object();
    static object lock2 = new object();

    static void Method1()
    {
        lock (lock1)
        {
            Thread.Sleep(100);

            lock (lock2)
            {
                Console.WriteLine("Method1");
            }
        }
    }

    static void Method2()
    {
        lock (lock2)
        {
            Thread.Sleep(100);

            lock (lock1)
            {
                Console.WriteLine("Method2");
            }
        }
    }

    static void Main()
    {
        Thread t1 = new Thread(Method1);
        Thread t2 = new Thread(Method2);

        t1.Start();
        t2.Start();
    }
}