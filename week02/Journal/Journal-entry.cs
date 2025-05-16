using System;

public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"Date: {Date}Prompt: {Prompt}Response: {Response}";
    }

    public string ToFileFormat()
    {
        return $"{Date}|{Prompt}|{Response}";
    }

    public static JournalEntry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        return new JournalEntry(parts[1], parts[2]) { Date = parts[0] };
    }
}
