using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Random rnd = new Random();
        int randomIndex = rnd.Next(0, 5);
        Console.WriteLine("Thank you for using the Scripture Memorizer game. I'll produce a random scripture. Hit enter to remove words from the scripture. Type 'quit' to exit.");
        RandomVerse newVerse = new RandomVerse();
        List<Word> verse = newVerse.GetRandomVerse(randomIndex);
        Reference reference = newVerse.GetRandomReference(randomIndex);    
        Scripture randScripture = new Scripture(reference, verse);
        
        randScripture.GetDisplayText();
        string userInput = "";
        while (true)
        {
            userInput = Console.ReadLine()?.Trim().ToLower();
            if (userInput == "quit")
            {
                Console.WriteLine("Thank you for playing.");
                break;
            }

            if (randScripture.IsCompletelyHidden() == true)
            {
                Console.Clear();
                Console.WriteLine("The scripture is now completely hidden:");
                randScripture.GetDisplayText();
                Console.WriteLine("Thank you for playing.");
                break;
            }
            else
            {
                randScripture.HideRandomWords(3);
                Console.Clear();
                Console.WriteLine("Thank you for using the Scripture Memorizer game. I'll produce a random scripture. Hit enter to remove words from the scripture. Type 'quit' to exit.");
                randScripture.GetDisplayText();
            }
        }
    }
}