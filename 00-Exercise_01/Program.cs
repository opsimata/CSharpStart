using System;

class Program
{
    static void Main(string[] args)
    {
        // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
        // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
        // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

        double salary = 3800.0;

        Console.Write("Exercise 01:\n");

        if (salary >= 1900.0 && salary <= 2800.0)
        {
            Console.WriteLine("\nA sua aliquota é de 7%");
            Console.WriteLine("\nVocê pode deduzir até R$ 142");
        }
        else if (salary >= 2800.01 && salary <= 3751.0)
        {
            Console.WriteLine("\nA sua aliquota é de 15%");
            Console.WriteLine("\nVocê pode deduzir até R$ 350");
        }
        else if (salary >= 3751.01 && salary <= 4664.0)
        {
            Console.WriteLine("\nA sua aliquota é de 22.5%");
            Console.WriteLine("\nVocê pode deduzir até R$ 636");
        }

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}