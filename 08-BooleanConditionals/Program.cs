using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conditional Statements:");

        int age = 16, qttPeople = 2;

        bool accompanied = qttPeople >= 2;
        bool group = true;

        if (age >= 18 || accompanied)
        {
            Console.WriteLine("\nAllowed in!");
        }
        else
        {
            Console.WriteLine("\nNot allowed!");
        }

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}