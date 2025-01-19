using System;
using System.Collections.Generic;
using System.IO;

// a class template for objects called Journal. It receives Entry class objects and stores them in a list called journal.
// it can create a new entry, display all current entries, save all current entries to a txt file, and load strings from the txt file to entry attribute.

public class Journal
{
    // variables
    public List<Entry> _entries = new List<Entry>();

    // methods
    public Entry AddEntry()
    {
        Entry thisEntry = new Entry();
        Console.WriteLine(DateTime.Now.ToString("MM-dd-yyyy"));
        thisEntry._date = DateTime.Now.ToString("MM-dd-yyyy");

        PromptGenerator newPrompt = new PromptGenerator();
        thisEntry._promptText = newPrompt.GetRandomPrompt();
        Console.WriteLine($"{thisEntry._promptText}");
        
        thisEntry._entryText = Console.ReadLine();

        return thisEntry;
    }

    public void Add(Entry currentEntry)
    {
        _entries.Add(currentEntry);
    }

private const string fileName = "Journal.txt";
    public void SaveToFile(List<Entry> currentEntry)
    {
        Console.WriteLine("Saving to file....");       

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry saveEntry in currentEntry)
            {
                outputFile.WriteLine($"{saveEntry._date}***{saveEntry._promptText}***{saveEntry._entryText}");
            }
            
        }
    }

    public static List<Entry> LoadFromFile()
    {
        List<Entry> _currentEntries = new List<Entry>();
        string[] JournalLines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in JournalLines)
        {
            string[] parts = line.Split("***");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _currentEntries.Add(newEntry);
        }

        return _currentEntries;
    }
}