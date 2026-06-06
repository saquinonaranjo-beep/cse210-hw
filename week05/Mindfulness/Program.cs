using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Quit");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            BreathingActivity activity = new BreathingActivity();
            activity.Run();
        }
    }
}
