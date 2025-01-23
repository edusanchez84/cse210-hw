using System;
using System.Collections.Generic;

class Scripture
{
    private Reference reference;
    private List<Word> _words;

    public Scripture()
    {
        _words = new List<Word>();
        reference = new Reference("Book", "1", "1");
    }

    public Scripture(Reference Reference, string Text)
    {
        _words = new List<Word>(Text.Split("$").Select(word => new Word(word)));
    }

    public string GetDisplayText(string fileHead, string fileVerse)
    {
        Console.Write($"{reference.GetDisplayText(fileHead)} ");   
        _words = fileVerse.Split('$').Select(word => new Word(word)).ToList();
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText());
        }
        return "";
    }

    public void HideRandomWords(List<Word> randomList, string fileHead)
    {
        Random random2 = new Random();
            var randomElements = GetWords().OrderBy(x => random2.Next()).Take(3).ToList();
            randomList.AddRange(randomElements);
        Console.Write(reference.GetDisplayText(fileHead));
        foreach (Word word in randomList)
        {
            word.Hide();
        }
        foreach (Word word in GetWords())
        {
            Console.Write(word.GetDisplayText());
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public List<Word> GetWords()
    {
        return _words;
    }
}