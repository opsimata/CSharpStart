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

        string phrase = "Lorem";
        Console.WriteLine("\nPhrase: " + phrase + ", " + 2023);

        string emptyString = "";
        Console.WriteLine("\nEmpty String: " + emptyString);

        Console.WriteLine("\n");

        string itemString = @"Exemple:
    - Break 1
    - Break 2
    - Break 3"
    ;
        Console.WriteLine(itemString);

        //char can't be empty.

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}