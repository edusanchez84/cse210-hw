using System;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {
    
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }
    }    
}