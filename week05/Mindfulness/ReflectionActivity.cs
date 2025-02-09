using System;
using System.IO;

public class ReflectionActivity : Activity
{
    //attributes
    List<string> _prompts = [];
    List<string> _questions = [];

    //constructor
    public ReflectionActivity(): base()
    {
        _name = "Reflection";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. \nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    //methods
    private string GetRandomReflectionPrompt()
    {
        if (_prompts.Count == 0)
        {
            _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless.",
            ];
        }
        RandomPrompts GetRandom = new RandomPrompts();
        string prompt = GetRandom.GetRandomPrompt(_prompts);
        _prompts.Remove(prompt);
        return prompt;
    }

    private string GetRandomQuestion()
    {
            if (_questions.Count == 0)
        {
            _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
            ];
        }
        RandomPrompts GetRandom = new RandomPrompts();
        string question = GetRandom.GetRandomPrompt(_questions);
        _questions.Remove(question);
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomReflectionPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }

    public void Run()
    {
        Console.Clear();
        DisplayPrompt();
        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
        Console.WriteLine("\nReflect on the following questions related to that experience.");
        Pause(3);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_duration + 3);
        while (currentTime <= endTime)
        {

            DisplayQuestion();
            Pause(3);
            currentTime = DateTime.Now;
            if (currentTime >= endTime)
            {
                break;
            }
        }
    }
}