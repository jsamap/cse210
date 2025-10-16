class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    public override string GetDisplayText()
    {
        return $"[ ] {_name} ({_description})";
    }
    public override int Accomplish()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }
    public override void Complete() { }
    public override string GetTextToSave()
    {
        return $"{this.GetType().Name}##{_name}##{_description}##{_points}";
    }

}