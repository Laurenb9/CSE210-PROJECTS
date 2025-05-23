using System;

class Program
{
    static void Main(string[] args)
    {
         Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all your heart and lean not on your own understanding.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit") break;

            scripture.HideRandomWords(3);

            if (scripture.AllWordsHidden())
            {
                scripture.Display();
                Console.WriteLine("All words have been hidden! Program ending.");
                break;
            }
        }
    }
}
