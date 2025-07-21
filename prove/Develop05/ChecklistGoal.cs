public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    public int CurrentCount { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints)
        : base(name, description, points)
    {
        TargetCount = targetCount;
        BonusPoints = bonusPoints;
        CurrentCount = 0;
    }

    public override bool IsComplete() => CurrentCount >= TargetCount;

    public override int RecordEvent()
    {
        if (!IsComplete())
        {
            CurrentCount++;
            return Points + (IsComplete() ? BonusPoints : 0);
        }
        return 0;
    }

    public override string GetDetails() => $"[{(IsComplete() ? "X" : " ")}] {Name} ({Description}) -- Completed {CurrentCount}/{TargetCount} times";

    public override string GetSaveString() => $"ChecklistGoal|{Name}|{Description}|{Points}|{TargetCount}|{BonusPoints}|{CurrentCount}";
}