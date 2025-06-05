using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him and he shall direct thy paths.";
        var scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Typewriter.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Typewriter.WriteLine("All words are now hidden. Can no longer continue.");
    }
}
