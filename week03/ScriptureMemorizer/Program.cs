using System;
class Program
{
    static  void Main(string[] args)
    {
        Reference reference = new Reference( "John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
            // Creativity:
            // This program exceeds core requirements by hiding
            // 3 random words at a time instead of only one word.

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            for (int i = 0; i < 3; i++)
            {
                scripture.HideRandomWords();
            }
        }


            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
    }
}