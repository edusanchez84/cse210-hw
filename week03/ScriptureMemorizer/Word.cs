using System;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text0)
    {
        _text = text0;
        _isHidden = false;
    }

    public override string ToString()
    {
        return _text;
    }

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
            return string.Concat(_text.Select(c => c == ' ' ? ' ' : '_')); 
        }

        else
        {
            return _text;
        }
        
    }
}