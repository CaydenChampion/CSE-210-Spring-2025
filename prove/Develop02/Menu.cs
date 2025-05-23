using System;

public class Menu
{
    private Journal journal;
    private PromptGenerator promptGenerator;

    public Menu()
    {
        journal = new Journal();
        promptGenerator = new PromptGenerator();
    }

    public void Display()
    {
        bool running = true;

        while (running)
        {
            Typewriter.Print("\nJournal Menu:");
            Typewriter.Print("1. Write a new entry");
            Typewriter.Print("2. Display the journal");
            Typewriter.Print("3. Save the journal to a file");
            Typewriter.Print("4. Load the journal from a file");
            Typewriter.Print("5. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    Typewriter.Print("Goodbye!", 40);
                    running = false;
                    break;
                default:
                    Typewriter.Print("Invalid choice. Please select again.");
                    break;
            }
        }
    }

    private void AddEntry()
    {
        string prompt = promptGenerator.GetRandomPrompt();
        Typewriter.Print($"\nPrompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        JournalEntry entry = new JournalEntry(date, prompt, response);
        journal.AddEntry(entry);
        Typewriter.Print("Entry recorded.\n", 30);
    }

    private void SaveJournal()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }

    private void LoadJournal()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
}
