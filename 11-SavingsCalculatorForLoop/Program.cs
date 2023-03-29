using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Savings Calculator:\n");

        double deposits = 1000;

        //monthly return: 0.5% + 1000 deposit.

        for (int month = 1; month <= 12; month++)
        {
            deposits *= 0.005;
            Console.Write("\nTotal income in month " + month + ": $" + deposits);
        }

        Console.Write("\n\nPress any key to close...");
        Console.ReadLine();
    }
}