using System;
using System.Globalization;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _response;
    
    List<int> _randomLines = [];

    public ListingActivity(string name, string description) : base (name, description)
    {
        _count = 0;
        _prompts = 
        [
            "-- Who are people that you appreciate? --",
            "-- What are personal strengths of yours? --",
            "-- Who are people that you have helped this week? --",
            "-- When have you felt the Holy Ghost this month? --",
            "-- Who are some of your personal heroes? --"
        ];
        _response = [];
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
       
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            _response.Add(Console.ReadLine());
            _count++;
        }
      
        Console.WriteLine($"You listed {_count} items");
    }

    public int GetRandomPrompt()
    {
        Random random1 = new Random();
        int randomLine = random1.Next(_prompts.Count());
        bool containsAll = Enumerable.Range(0, 4).All(n => _randomLines.Contains(n));
        if (containsAll)
        {
            _randomLines = [];
            _randomLines.Add(randomLine);
        }
        else
        {
            while (_randomLines.Contains(randomLine))
            {
                randomLine = random1.Next(_prompts.Count());
            }
            
            _randomLines.Add(randomLine);
        }
        return randomLine;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts[GetRandomPrompt()]);       
    }

    public List<string> GetListFromUser()
    {
        return _response;
    }
}