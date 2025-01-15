using System;

class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "What was the happiest interaction you had today?",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
            "If I had to remember one thing about today, what would it be?",
            "What was the best part of my day?"
        };
    }
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count); // Get a random index
        return _prompts[index];
    }
}