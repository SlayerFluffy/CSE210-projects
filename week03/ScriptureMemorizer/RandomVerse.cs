using System;

public class RandomVerse()
{
        //attributes
    public List<string> _verseLibrary = new List<string> {"For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
    "And this gospel of the kingdom shall be preached in all the world for a witness unto all nations; and then shall the end come. When ye therefore shall see the abomination of desolation, spoken of by Daniel the prophet, stand in the holy place, (whoso readeth, let him understand:)", 
    "Therefore remove sorrow from thy heart, and put away evil from thy flesh: for childhood and youth are vanity.",
    "I will bless the Lord at all times: his praise shall continually be in my mouth.", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all they ways acknowledge him, and he shall direct thy paths."};

    public List<string> _referenceLibrary = new List<string> {"John~~~3~~~16", "Matthew~~~24~~~14~~~15", "Ecclesiastes~~~11~~~10", "Psalm~~~34~~~1", "Proverbs~~~3~~~5~~~6"};

    //methods
    public List<Word> GetRandomVerse(int rnd)
    {
        string thisRandVerse = _verseLibrary[rnd];
        List<Word> thisVerse = new List<Word>();
        string[] eachWord = thisRandVerse.Split(" ");
        foreach (string line in eachWord)
            {
                Word newWord = new Word(line);
                thisVerse.Add(newWord);
            }
        
        return thisVerse;
    }
    
    public Reference GetRandomReference(int rnd)
    {
        string fullRandReference = _referenceLibrary[rnd];
        string[] part = fullRandReference.Split("~~~");
        string book = part[0];
        int chapter = int.Parse(part[1]);
        int verse = int.Parse(part[2]);
        // how do I make it run endVerse only if it is present?
        if (part.Length == 4 )
        {
            int endVerse = int.Parse(part[3]);
            Reference thisReference = new Reference(book, chapter, verse, endVerse);
            return thisReference;            
        }
        else
        {
            Reference thisReference = new Reference(book, chapter, verse);
            return thisReference;
        }
    }
}