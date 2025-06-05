using System;

int choice;

while (true)
{
    Console.Clear();
    Console.WriteLine("Mindfulness Program");
    Console.WriteLine("1. Start Breathing Activity");
    Console.WriteLine("2. Start Reflecting Activity");
    Console.WriteLine("3. Start Listing Activity");
    Console.WriteLine("4. Quit");

    Console.Write("Select an option: ");
    string input = Console.ReadLine();

    while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
    {
        Console.WriteLine("Please enter a valid number between 1 and 4.");
        Console.Write("Select an option: ");
        input = Console.ReadLine();
    }

    if (choice == 4)
    {
        Console.WriteLine("Goodbye!");
        break;  // salir del while(true)
    }

    switch (choice)
    {
        case 1:
            BreathingActivity breathing = new BreathingActivity();
            breathing.Run();
            break;
        case 2:
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.Run();
            break;
        case 3:
            ListingActivity listing = new ListingActivity();
            listing.Run();
            break;
    }
}
