using System;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

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
        List<string> response = [];

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            response.Add(Console.ReadLine());
            _count++;
        }
      
        Console.WriteLine($"You listed {_count} items");
    }

    public string GetRandomPrompt()
    {
        Random random1 = new Random();
        int randomLine = random1.Next(_prompts.Count());
        return _prompts[randomLine];

    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}