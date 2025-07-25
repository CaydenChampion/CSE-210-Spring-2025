public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override bool IsComplete() => _isComplete;

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetDetails() => $"[{(_isComplete ? "X" : " ")}] {Name} ({Description})";

    public override string GetSaveString() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}