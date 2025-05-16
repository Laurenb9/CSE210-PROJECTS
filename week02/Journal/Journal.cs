using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What made me smile today?",
        "What did I learn today?",
        "What emotion did I feel most strongly today?"
    };

    public void WriteNewEntry()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"{prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        JournalEntry entry = new JournalEntry(prompt, response);
        entries.Add(entry);
        Console.WriteLine("Entry saved successfully.");
    }

    public void DisplayJournal()
    {
        Console.WriteLine("--- Complete Journal ---");
        foreach (var entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.ToFileFormat());
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        if (File.Exists(filename))
        {
            foreach (string line in File.ReadAllLines(filename))
            {
                entries.Add(JournalEntry.FromFileFormat(line));
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
