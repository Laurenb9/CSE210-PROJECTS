using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing Activity", "This activity helps you reflect by listing as many positive things as you can.")
    {
        _prompts = new List<string> {
            "List the people who have influenced you positively.",
            "List things you're grateful for today.",
            "List the goals you're proud of achieving."
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();

        Console.WriteLine($"{prompt}");
        Console.WriteLine("You may begin listing items. Press enter after each one.");

        List<string> items = GetListFromUser();

        _count = items.Count;

        Console.WriteLine($"You listed {_count} items. Great job!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                list.Add(input);
            }
        }

        return list;
    }
}
