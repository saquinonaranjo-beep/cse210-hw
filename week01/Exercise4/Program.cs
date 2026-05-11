using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                number.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int num in number)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        double average = (double)sum / number.Count;
        Console.WriteLine($"The average is: {average}");

        int largest = number[0];
        foreach (int num in number)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");
    }
}