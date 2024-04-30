using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();

        int myAge = 18;
        float myHeight = 1.6509f;
        string myName = "Manuel Otero Jr.";
        string favColor = "purple";
        bool isTuesday = true;
        bool isWednesday = false;
        bool isThursday = false;
        int dayNumber = rand.Next(1, 101); // Generate a random integer between 1 and 100
        int time = 0;

        Console.WriteLine("Hello, world! This script was made by " + myName + "! He is " + myAge + " years old, " + myHeight + " meters tall, and his favorite color is " + favColor + "!");

        if (isTuesday)
        {
            Console.WriteLine("It's Tuesday, the first day of the program!");
        }
        else if (isWednesday)
        {
            Console.WriteLine("It's Wednesday! Nothing beats a relaxing Lab Day!");
        }
        else if (isThursday)
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

        //for (time < 1; time++)
        //{
        //    Console.WriteLine("This program has been running for " + time + " seconds!");
        //    Thread.Sleep(1000);
        //}
        //for (time > 1; time++)
        //{
       //     Console.WriteLine(time + " seconds!");
       //     Thread.Sleep(1000);
       //}
    }
}
