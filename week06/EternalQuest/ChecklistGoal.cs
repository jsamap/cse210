class ChecklistGoal : Goal
{
    private int _progress;
    private int _progressForBonus;
    private int _bonusPoints;
    private bool _isCompleted;
    public ChecklistGoal(string name, string description, int points, int progressForBonus, int bonusPoints, int progress = 0, bool isComplete = false) : base(name, description, points)
    {
        _progress = progress;
        _progressForBonus = progressForBonus;
        _bonusPoints = bonusPoints;
    }

    public override string GetDisplayText()
    {
        return $"[{(_isCompleted ? "x" : " ")}] {_name} ({_description}) —— Currently completed: {_progress}/{_progressForBonus}";
    }
    public override int Accomplish()
    {
        _progress++;

        if (_progress == _progressForBonus)
        {
            Complete();
            Console.WriteLine($"Congratulations! You have earned {_points} points + {_bonusPoints} bonus points!");
            return _points+_bonusPoints;            
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
        }
    }
    public override void Complete()
    {
        _isCompleted = true;
    }
    public override string GetTextToSave()
    {
        return $"{this.GetType().Name}##{_name}##{_description}##{_points}##{_progressForBonus}##{_bonusPoints}##{_progress}##{_isCompleted}";
    }
}