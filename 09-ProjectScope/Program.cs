using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Conditional Statements:");

        int age = 16, qttPeople = 2;

        bool accompanied = qttPeople >= 2;

        string addtText;

        if (accompanied == true)
        {
            addtText = "The guest is accompanied!";
        }
        else
        {
            addtText = "The guest is underaged and isn't accompanied!";
        }

        if (age >= 18 || accompanied)
        {
            Console.WriteLine("\nAllowed in!");
            Console.WriteLine("\n" + addtText);
        }
        else
        {
            Console.WriteLine("\nNot allowed!");
            Console.WriteLine("\n" + addtText);
        }

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}