using System;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("What is your grade percentage? ");
       string answer = Console.ReadLine();
       int percent = int.Parse(answer);

         if (percent >= 90)
         {
              Console.WriteLine("You got an A.");
         }
         else if (percent >= 80)
         {
              Console.WriteLine("You got a B.");
         }
         else if (percent >= 70)
         {
              Console.WriteLine("You got a C.");
         }
         else if (percent >= 60)
         {
              Console.WriteLine("You got a D.");
         }
         else
         {
              Console.WriteLine("You got an F.");
         }
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed.");
        }
        else
        {
            Console.WriteLine("You failed.");
        }
    }
}