using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conditional Statements:");

        int age = 16, qttPeople = 2;

        if (age >= 18)
        {
            Console.WriteLine("\nAllowed in!");
        }
        else
        {
            if (qttPeople => 2)
            {
                Console.WriteLine("\nAllowed in with a legal of age companion!");
            }
            else
            {
                Console.WriteLine("\nNot allowed!");
            }
        }

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}