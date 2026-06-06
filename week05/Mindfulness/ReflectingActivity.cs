using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you accomplished something meaningful."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself?",
        "How did you feel when it was complete?",
        "What made this time different from others?",
        "How can you apply this experience in the future?"
    };

    public ReflectingActivity()
        : base(
            "Reflecting",
            "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine(_prompts[random.Next(_prompts.Count)]);
        Console.WriteLine("\nThink about it...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine(_questions[random.Next(_questions.Count)]);
            ShowSpinner(5);
        }

        DisplayEndMessage();
    }
}