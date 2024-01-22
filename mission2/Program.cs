// See https://aka.ms/new-console-template for more information

using mission2;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        // initialize my rumrolls variable 
        int numRolls = 0;

        // welcome the user
        Console.WriteLine("Welcome to the dice throwing simulator!");

        // ask the user how many dice rolls they want
        System.Console.Write("\nHow many dice rolls would you like to simulate? ");

        //store the number input in the numrolls variable 
        numRolls = int.Parse(System.Console.ReadLine());

        //create an instance of dice rolls 
        DiceRoll diceroll = new DiceRoll();

        // simulate dice rolls and create results array
        int[] results = diceroll.SimulateRolls(numRolls);

        //print histogram
        PrintHistogram(results);

        // say goodbye
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }

    static void PrintHistogram(int[] results)
    {

        // calculate total rolls
        int totalRolls = results.Sum();

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + totalRolls + ".\n");

        for (int i = 2; i <= 12; i++)
        {
            //calculate the percentage
            double percentage = (double)results[i] / totalRolls * 100;

            //print the actual histogram
            int asteriskCount = (int)Math.Round(percentage / 1);
            Console.Write($"{i}: {new string('*', asteriskCount)}\n");
        }
    }
}
