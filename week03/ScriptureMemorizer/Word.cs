using System;
using System.Runtime.CompilerServices;


public class Word
{
    // attributes
    private string _text;
    private bool _isHidden = false;

    // constructor
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
            return _text;
    }
}