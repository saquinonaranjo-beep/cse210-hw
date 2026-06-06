public class BreathingActivity: Activity

    {
        public void Run()
    {
        DisplayStartMessage();
        
        int elapsedTime = 0;
        while (elapsedTime < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(5);
            Console.WriteLine("\nBreathe out...");
            ShowCountdown(5);
            elapsedTime += 10;
        }
        DisplayEndMessage();
    }
    }