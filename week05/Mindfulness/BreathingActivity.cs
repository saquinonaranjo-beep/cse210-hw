using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by walking you through breathing in and out slowly.")
    {
    }

    public void Run()
    {
        DisplayStartMessage();

        int elapsedTime = 0;

        while (elapsedTime < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(5);

            Console.Write("\nBreathe out... ");
            ShowCountdown(5);

            Console.WriteLine();

            elapsedTime += 10;
        }

        DisplayEndMessage();
    }
}