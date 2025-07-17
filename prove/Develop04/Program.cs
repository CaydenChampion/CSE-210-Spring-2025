using System;

namespace MindfulnessApp
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Typewriter.Print("Mindfulness Program\n");
                Typewriter.Print("1. Breathing");
                Typewriter.Print("2. Reflection");
                Typewriter.Print("3. Listing");
                Typewriter.Print("4. Quit\n");
                Typewriter.Print("Choose an option: ");
                var choice = Console.ReadLine();

                if (choice == "4") break;

                Console.Write("Enter duration in seconds: ");
                if (!int.TryParse(Console.ReadLine(), out int duration) || duration <= 0)
                {
                    Typewriter.Print("Invalid duration. Press Enter to try again.");
                    Console.ReadLine();
                    continue;
                }

                Activity activity = choice switch
                {
                    "1" => new Breathing(duration),
                    "2" => new Reflection(duration),
                    "3" => new Listing(duration),
                    _ => null
                };

                if (activity != null)
                {
                    activity.RunActivity();
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                }
            }
        }
    }
}
