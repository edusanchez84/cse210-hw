using System;

class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = $"-{endVerse}";
    }


    public string GetDisplayText(string fileHead)
    {
        string[] separatedFileHead = fileHead.Split("$");
        if (separatedFileHead.Length == 4)
        {
            _book = separatedFileHead[0];
            _chapter = separatedFileHead[1];
            _verse = separatedFileHead[2];
            _endVerse = $"-{separatedFileHead[3]}";
        }
    else
        {
            _book = separatedFileHead[0];
            _chapter = separatedFileHead[1];
            _verse = separatedFileHead[2];
            _endVerse = "";
        }
    return $"{_book} {_chapter}:{_verse}{_endVerse} ";
    }
    
}