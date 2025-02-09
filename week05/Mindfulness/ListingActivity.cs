using System;
using System.IO;

public class ListingActivity : Activity
{
    //attributes. _count is used to tally responses given by user. 
    // _prompts stores a list of prompts to be randomly selected from.
    private int _count;
    private List<string> _prompts = [];

    //constructor
    public ListingActivity() : base()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public string GetRandomListingPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
        ];
        }
        RandomPrompts GetRandom = new RandomPrompts();
        string prompt = GetRandom.GetRandomPrompt(_prompts);
        _prompts.Remove(prompt);
        return prompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration);
        while (currentTime <= endTime)
        {
            string input = Console.ReadLine();
            responses.Add(input);
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
        }
        return responses;
    }
    public void Run()
    {
        string prompt = GetRandomListingPrompt();
        Console.Clear();
        Console.WriteLine(prompt);
        ShowCountDown(5);
        Console.WriteLine();
        List<string> listedItems = GetListFromUser();
        _count = listedItems.Count;
        Console.WriteLine();
        Console.WriteLine($"Good job! You listed {_count} things!");
        Thread.Sleep(3000);
    }
}