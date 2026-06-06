public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine("Get ready...");
        Thread.Sleep(2000);
    }


    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        Thread.Sleep(3000);
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

        public void ShowSpinner(int duration)
        {
            string[] spinner = { "|", "/", "-", "\\" };
            int spinnerIndex = 0;
            int elapsedTime = 0;

            while (elapsedTime < duration)
            {
                Console.Write(spinner[spinnerIndex]);
                Thread.Sleep(250);
                Console.Write("\b \b");
                spinnerIndex = (spinnerIndex + 1) % spinner.Length;
                elapsedTime += 250;
            }
        }
    }


