using System;

// a class template for objects known as PromptGenerator. 
// responsible for holding a list of strings.
// used to randomly select one string from the list.

public class PromptGenerator
{
    //attributes
    public List<string> _prompts = new List<string> {"Who was the most interesting person I interacted with today: ?", "What was the best part of my day?: ", 
    "How did I see the hand of the Lord in my life today?: ", "What was the strongest emotion I felt today?: ", "If I had one thing I could do over today, what would it be?: ",
    "What am I proud of doing today?: ", "What was the weirdest thing that happened today?: "};

    //methods
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int thisPrompt = rnd.Next(_prompts.Count);
        return _prompts[thisPrompt];
    }
}