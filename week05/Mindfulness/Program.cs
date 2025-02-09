using System;
using System.IO;
// extra credit: I wrote the functions for the random prompts in a way that the prompts
// are removed from the list once used so they are not re-used during the same run.
// I also added an extra class to choose random prompts when given a list.
class Program
{
    static void Main(string[] args)
    {
        string choice = "0";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness program!");
            Thread.Sleep(1500);
            Console.WriteLine("Which activity would you like to do?");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndMessage();
            }
            else if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndMessage();
            }
            else if (choice == "3")
            {
                ReflectionActivity reflect = new ReflectionActivity();
                reflect.DisplayStartingMessage();
                reflect.Run();
                reflect.DisplayEndMessage();
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Thank you for using the Mindfulness program. Have a great day.");
                break;
            }
        }
    }
}