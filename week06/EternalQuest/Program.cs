// EternalQuest - Main Program
using System;

class Program
{
    static void Main(string[] args)
    {
        UserProfile user = new UserProfile();
        GoalManager goalManager = new GoalManager(user);

        int choice = -1;
        while (choice != 6)
        {
            Console.Clear();
            Console.WriteLine("--- Eternal Quest ---");
            Console.WriteLine($"Score: {user.Score} | Level: {user.Level} - Title: {user.Title}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    goalManager.CreateGoal();
                    break;
                case 2:
                    goalManager.DisplayGoals();
                    break;
                case 3:
                    goalManager.RecordEvent();
                    break;
                case 4:
                    goalManager.SaveGoals();
                    break;
                case 5:
                    goalManager.LoadGoals();
                    break;
                case 6:
                    Console.WriteLine("Goodbye, brave quester!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}