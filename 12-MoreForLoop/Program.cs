using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Long term savings calculator:\n");

        double appreciationIndex = 1.005, investment = 1000;

        //monthly return: 0.5% + 1000 deposit.

        for (int years = 1; years <= 5; years++)
        {
            for (int month = 1; month <= 12; month++)
            {
                investment *= appreciationIndex;
            }
            appreciationIndex += 0.001;
        }

        Console.Write("\nTotal income in 5 year: $" + investment);

        Console.Write("\n\nPress any key to close...");
        Console.ReadLine();
    }
}