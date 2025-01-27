using System;

public class Reference
{
    // attributes
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructors
    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // methods
    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            string thisReference = $"{_book} {_chapter}: {_verse}";
            return thisReference;
        }
        else
        {
            string thisReference = $"{_book} {_chapter}: {_verse} - {_endVerse}";
            return thisReference;
        }
    }
}