using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
        _prompts.Add("What was the best part of your day?");
        _prompts.Add("What are you grateful for today?");
        _prompts.Add("What is something new you learned today?");
        _prompts.Add("Describe a challenge you faced and how you overcame it.");
        _prompts.Add("What is a goal you have for tomorrow?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }


}

