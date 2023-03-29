using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Long term savings calculator:\n\n");

        double appreciationIndex = 1.005, investment = 1000;

        //*
        //**
        //***
        //****
        //*****

        for (int lines = 1; lines <= 5; lines++)
        {
            for (int columns = 1; columns <= 10; columns++)
            {
                Console.Write("*");
                if (columns >= lines)
                {
                    break;
                }
            }
            Console.WriteLine();
        }

        Console.Write("\nPress any key to close...");
        Console.ReadLine();
    }
}