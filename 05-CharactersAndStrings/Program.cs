using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Characters:");

        char character = 'a';
        Console.WriteLine("\nCharacter: " + character);

        character = (char)65;
        Console.WriteLine("\nCharacter: " + character);

        character = (char)(65 + 1);
        Console.WriteLine("\nCharacter: " + character);

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}