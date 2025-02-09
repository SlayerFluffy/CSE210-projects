using System;
using System.IO;
//template for parent class Activity
public class Activity
{
    // Attributes. name, description, and length in seconds of activities
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _pauseSymbol = ["|", "/", "-", "\\"];

    //constructor
    public Activity()
    {

    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 3;
    }
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //methods.
    public void DisplayStartingMessage()
    // displays a starting message for each activity. Will show name, description, and ask for a duration
    // in seconds to construct and display message. Then tell user to prepare for the activity.
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Thread.Sleep(2500);
        Console.WriteLine(_description);
        Thread.Sleep(2500);
        Console.WriteLine($"How many seconds would you like to do the {_name} Activity?");
        string stringDuration = Console.ReadLine();
        _duration = Int32.Parse(stringDuration);

        Console.WriteLine("Please prepare for the activity.");
        Pause(3);
    }

    public void DisplayEndMessage()
    // displays a thank you message for completing the activity, including the activity name and duration.
    {
        Console.Clear();
        Console.WriteLine($"Well done! You've completed the {_name} Activity for {_duration} seconds.");
        Pause(3);
        Console.Clear();
    }

    public void Pause(int seconds)
    // a method to display a 3 second pause animation
    {
        
        foreach (int i in Enumerable.Range(0, seconds))
        {
            foreach (string symbol in _pauseSymbol)
            {
                Console.Write(symbol);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown(int seconds)
    // displays a countdown timer.
    {
        foreach (int i in Enumerable.Range(0, seconds))
        {
            Console.Write(i+1);
            Thread.Sleep(1000);
            if (i+1 >= 10)
            {
                Console.Write("\b\b  \b\b");
            }
            else if (i+1 >= 100)
            {
                Console.Write("\b\b\b   \b\b\b");
            }
            else
            {
                Console.Write("\b \b");
            }
        }
    }
}