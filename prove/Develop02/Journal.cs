using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<JournalEntry> entries = new List<JournalEntry>();

    public void AddEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Typewriter.Print("No journal entries found.");
            return;
        }

        foreach (var entry in entries)
        {
            Console.WriteLine(entry.GetScreenString());
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        foreach (var entry in entries)
        {
            writer.WriteLine(entry.GetFileString());
        }
        Typewriter.Print($"Journal saved to {filename}");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Typewriter.Print("File not found.");
            return;
        }

        entries.Clear();
        foreach (var line in File.ReadAllLines(filename))
        {
            var parts = line.Split("~|~");
            if (parts.Length == 3)
            {
                var entry = new JournalEntry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }

        Typewriter.Print($"Journal loaded from {filename}");
    }
}
