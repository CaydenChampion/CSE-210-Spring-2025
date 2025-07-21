using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> Goals { get; set; } = new List<Goal>();
    public int Score { get; set; } = 0;

    public void AddGoal(Goal goal) => Goals.Add(goal);

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < Goals.Count)
        {
            Score += Goals[goalIndex].RecordEvent();
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < Goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Goals[i].GetDetails()}");
        }
    }

    public void SaveToFile(string filename)
    {
        using StreamWriter writer = new StreamWriter(filename);
        writer.WriteLine(Score);
        foreach (Goal goal in Goals)
        {
            writer.WriteLine(goal.GetSaveString());
        }
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename)) return;

        string[] lines = File.ReadAllLines(filename);
        Score = int.Parse(lines[0]);
        Goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    Goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])) { });
                    ((SimpleGoal)Goals[^1]).RecordEvent(); 
                    break;
                case "EternalGoal":
                    Goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    Goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]))
                    {
                        CurrentCount = int.Parse(parts[6])
                    });
                    break;
            }
        }
    }
}
