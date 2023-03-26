using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating Variables");

        int age;
        age = 23;

        Console.WriteLine("Age: " + age);


        age = 34 * 2 + 1;
        age = 4 * (2 + 3);

        Console.WriteLine("Age: " + age);

        Console.WriteLine("Press any key to close...");
        Console.ReadLine();

    }
}