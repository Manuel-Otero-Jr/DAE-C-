using System;
using System.Threading;

class Program
{
    private static int myAge = 18; // Declare 'myAge' as static field
    private static float myHeight = 1.6509f; // Declare 'myHeight' as static field
    private static string myName = "Manuel Otero Jr."; // Declare 'myName' as static field
    public static string favColor = "purple"; // Declare 'favColor' as static field
    private static bool isTuesday = true; // Declare 'isTuesday' as static field
    private static bool isWednesday = false; // Declare 'isWednesday' as static field
    private static bool isThursday = false; // Declare 'isThursday' as static field
    private static Random rand = new Random(); // Declare 'rand' as static field
    private static string[] favGames = {"Kirby Star Allies", "Honkai: Star Rail", "Super Smash Bros. Ultimate", "Dr. Robotnik's Ring Racers"}; // Declare 'favGames' as static field

    static void Main(string[] args)
    {
        int dayNumber = rand.Next(1, 101); // Generate a random integer between 1 and 100

        Console.WriteLine("Hello, world! This script was made by " + myName + "! He is " + myAge + " years old, " + myHeight + " meters tall, and his favorite color is " + favColor + "!");

        if (isTuesday)
        {
            Console.WriteLine("It's Tuesday, the first day of the program!");
        }
        else if (isWednesday)
        {
            Console.WriteLine("It's Wednesday! Nothing beats a relaxing Lab Day!");
        }
        else
        {
            Console.WriteLine("It's Thursday, the second day of the program!");
        }

        if (dayNumber > 50)
        {
            Console.WriteLine("Today's number of the day is " + dayNumber + ". That's a pretty high number!");
        }
        else
        {
            Console.WriteLine("Today's number of the day is " + dayNumber + ". That's a pretty low number!");
        }

        for (int i = 0; i < 4; i++) // Changed '5' to '4' as there are only 4 elements in favGames array
        {
            Console.WriteLine(favGames[i]); // Added semicolon at the end
        }
    }
}

