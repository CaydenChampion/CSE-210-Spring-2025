public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override bool IsComplete() => false;

    public override int RecordEvent() => Points;

    public override string GetDetails() => $"[∞] {Name} ({Description})";

    public override string GetSaveString() => $"EternalGoal|{Name}|{Description}|{Points}";
}
