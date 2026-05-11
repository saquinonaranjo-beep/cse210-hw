using System;

Console.Write("What is your magic number? ");
int magicNumber = int.Parse(Console.ReadLine());
Console.Write("What is your guess?");
int guess = int.Parse(Console.ReadLine());

while (guess != magicNumber)
{
    if (guess < magicNumber)
    {
        Console.WriteLine("Higher");
    }
    else if (guess > magicNumber)
    {
        Console.WriteLine("Lower");
    }
    Console.WriteLine("Wrong! Try again.");
    Console.Write("What is your guess?");
    guess = int.Parse(Console.ReadLine());

}
Console.WriteLine("Your guessed it");
