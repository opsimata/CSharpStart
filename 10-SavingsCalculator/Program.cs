using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Savings Calculator:\n");

        double deposits = 1000;
        int month = 1;

        //monthly return: 0.5% + 1000 deposit.

        while (month <= 12)
        {
            deposits = deposits + deposits * 0.005;
            Console.Write("\nTotal income in month " + month + ": $" + deposits);
            month++;
        }



        Console.Write("\n\nPress any key to close...");
        Console.ReadLine();
    }
}