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
                Console.WriteLine("Which file would you like to open? Just type the name of the file, file type will automatically be included: ");
                string fileName = Console.ReadLine();
                currentEntries = Journal.LoadFromFile(fileName);
            }

            else if (MenuOption == "4") // Save all entries in currentEntries as text strings in Journal.txt file
            {
                 Console.WriteLine("Please provide a filename. It will be saved as a .txt file type: ");
                string fileName = Console.ReadLine();
                Console.WriteLine("Saving entry to file....");
                foreach (Entry _journalEntries in currentEntries)
                {
                    thisJournal.SaveToFile(fileName, currentEntries);
                }
            }
            Console.WriteLine("What would you like to do next?\n1. Write new entry.\n2. Display current entries\n3. Load journal\n4. Save current entries to journal\n5. Quit");
            MenuOption = Console.ReadLine();
        }
        //thisJournal.SaveToFile(thisJournal);
    }
}