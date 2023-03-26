using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conversion of Variables:");

        double salary = 3148.14;

        int intSalary = (int)salary;

        Console.WriteLine("\nInteger salary: " + intSalary);

        //long, 64 bits variable
        long x = 200000000000;
        Console.WriteLine("\nX: " + x);

        short y = 20000;
        Console.WriteLine("\nY: " + y);

        float height = 1.76f;
        Console.WriteLine("\nFloat variable height: " + height);

        Console.WriteLine("\nPress any key to close...");
        Console.ReadLine();
    }
}