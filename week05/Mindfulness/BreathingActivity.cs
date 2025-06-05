using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through slow breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int interval = 5;

        for (int i = 0; i < _duration; i += interval * 2)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(interval);
            Console.Write("Breathe out... ");
            ShowCountDown(interval);
        }

        DisplayEndingMessage();
    }
}
