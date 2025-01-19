using System;

// A Class template for objects known as Entry. 
// Responsible for holding strings for attributes of date when entry is being written, a prompt text generated by PromptGenerator class, and text written by user.
// Can then be requested to display attributes formatted into a string.

public class Entry
{
    //attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    

    //methods
    public void Display()
    {
        Console.WriteLine($"{_date}\n{_promptText}\n{_entryText}");
    }
}