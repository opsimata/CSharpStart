using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Variables Attributions Concept:");

        int age = 30;

        int agePerson = age;

        Console.WriteLine("\nPerson 1 age: " + agePerson);

        age = 23;

        //No hoisting on C#.

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}