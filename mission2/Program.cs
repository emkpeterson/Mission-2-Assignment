// See https://aka.ms/new-console-template for more information

using mission2;
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
        System.Console.WriteLine("\nHow many dice rolls would you like to simulate?");

        //store the number input in the numrolls variable 
        numRolls = int.Parse(System.Console.ReadLine());

        //create an instance of dice rolls 
        DiceRoll diceroll = new DiceRoll();

        // simulate dice rolls and create results array
        int[] results = diceroll.SimulateRolls(numRolls);

        //print histogram
        PrintHistogram.PrintHist(results);

        // say goodbye
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}
