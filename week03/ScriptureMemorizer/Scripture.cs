using System;

public class Scripture
{
    // attributes
    private Reference _reference;
    private List<Word> _words;

    // constructors
    public Scripture(Reference reference, List<Word> verse)
    {
        _reference = reference;
        _words = verse;
    }

    // methods
    public void GetDisplayText()
    {
        string displayReference = $"{_reference.GetDisplayText()}\n";
        List<string> verseText = new List<string>();
        foreach (Word line in _words)
        {
            string newWord = line.GetDisplayText();
            verseText.Add(newWord);
        }
        string displayVerse = string.Join(" ", verseText);
        Console.WriteLine(displayReference);
        Console.WriteLine(displayVerse);
    }

    public void HideRandomWords(int numberOfWords)
    {
        Random rand = new Random();
        int visibleWordCount = _words.Count(word => !word.IsHidden());
        int wordsToHide = Math.Min(numberOfWords, visibleWordCount);
        for (int i = 0; i < wordsToHide; i++)
        {
            int randomIndex;
            do
            {
                randomIndex = rand.Next(0, _words.Count);
            } 
            while (_words[randomIndex].IsHidden());

            _words[randomIndex].Hide();
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}