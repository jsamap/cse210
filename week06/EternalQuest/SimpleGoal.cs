class SimpleGoal : Goal
{
    private bool _isCompleted;
    public SimpleGoal(string name, string description, int points, bool isCompleted = false) : base(name, description, points)
    {
        _isCompleted = isCompleted;
    }

    public override string GetDisplayText()
    {
        return $"[{(_isCompleted ? "x" : " ")}] {_name} ({_description})";
    }
    public override int Accomplish()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Complete();
        return _points;
    }
    public override void Complete()
    {
        _isCompleted = true;
    }
    public override string GetTextToSave()
    {
        return $"{this.GetType().Name}##{_name}##{_description}##{_points}##{_isCompleted}";
    }
}