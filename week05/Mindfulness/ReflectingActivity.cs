using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity() : base("Reflecting Activity", "This activity helps you reflect on your inner strength.")
    {
        _prompts = new List<string> {
            "Think of a time when you overcame a difficult challenge.",
            "Remember a moment when you helped someone in need.",
            "Recall a time when you stood up for what you believe in."
        };

        _questions = new List<string> {
            "Why was this experience meaningful to you?",
            "What did you learn about yourself?",
            "How can you apply this to your life now?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine($"Consider the following prompt:> {prompt}");
        Console.WriteLine("When you're ready, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions:");
    }

    public void DisplayQuestions()
    {
        int timePerQuestion = _duration / _questions.Count;

        foreach (string question in _questions)
        {
            Console.Write($"- {question} ");
            ShowSpinner(timePerQuestion);
        }
    }
}
