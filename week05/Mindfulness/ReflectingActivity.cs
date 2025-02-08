using System;

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity (string name, string description) : base (name, description)
    {
        _prompts = 
        [
        "-- Think of a time when you stood up for someone else. --",
        "-- Think of a time when you did something really difficult. --",
        "-- Think of a time when you helped someone in need. --",
        "-- Think of a time when you did something truly selfless. --"    
        ];
        _questions = 
        [
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        ];
    }

    public void Run()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string tapToContinue = Console.ReadLine(); 
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(5);
            Console.WriteLine();
        }
        
    }

    public string GetRandomPrompt()
    {
        Random random1 = new Random();
        int randomLine = random1.Next(_prompts.Count());
        return _prompts[randomLine];
    }

    public string GetRandomQuestion()
    {
        Random random2 = new Random();
        int randomLine = random2.Next(_questions.Count());
        return _questions[randomLine];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }     
}