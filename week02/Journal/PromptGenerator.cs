using System.Runtime.CompilerServices;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    
    public PromptGenerator()
    {
    _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What challenge did I face today, and how did I handle it?");
        _prompts.Add("Who did I interact with today that made an impact on me?");
        _prompts.Add("What is something I learned about myself today?");
        _prompts.Add("What is one thing I am grateful for today?");
    }



    public string GetRandomPrompt()
    {
        Random _random = new Random();
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}