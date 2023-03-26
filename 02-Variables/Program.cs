using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Variables:");

        int age;
        age = 23;

        Console.WriteLine("\nAge: " + age);


        age = 34 * 2 + 1;
        age = 4 * (2 + 3);

        Console.WriteLine("\nAge: " + age);

        Console.Write("\nPress any key to close...");
        Console.ReadLine();

    }
}