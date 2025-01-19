using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal.\nPlease choose one of the following options by submitting it's number.");
        Console.WriteLine("1. Write new entry.\n2. Display current entries\n3. Load journal\n4. Save current entries to journal\n5. Quit");
        string MenuOption = Console.ReadLine();

        Journal thisJournal = new Journal();
        List<Entry> currentEntries = new List<Entry>();

        while (MenuOption != "5")
        {
            if (MenuOption == "1") // Write new entry, add it to current journal object list
            {
                Entry currentEntry = thisJournal.AddEntry();
                thisJournal.Add(currentEntry);
                currentEntries.Add(currentEntry);
            }

            else if (MenuOption == "2") // Display current entries in current Journal object
            {
                
                foreach (Entry _journalEntries in currentEntries)
                {
                    _journalEntries.Display();
                }
            }
            
            else if (MenuOption == "3") // load strings from Journal.txt file into journal object
            {
                currentEntries = Journal.LoadFromFile();
            }

            else if (MenuOption == "4") // Save all entries in currentEntries as text strings in Journal.txt file
            {
                foreach (Entry _journalEntries in currentEntries)
                {
                    thisJournal.SaveToFile(currentEntries);
                }
            }
            Console.WriteLine("What would you like to do next?\n1. Write new entry.\n2. Display current entries\n3. Load journal\n4. Save current entries to journal\n5. Quit");
            MenuOption = Console.ReadLine();
        }
        //thisJournal.SaveToFile(thisJournal);
    }
}