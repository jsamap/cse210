abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public virtual string GetDisplayText()
    {
        return "";
    }
    public string GetName()
    {
        return _name;
    }
    public virtual int Accomplish()
    {
        return 0;
    }
    public virtual void Complete() { }
    public virtual string GetTextToSave()
    {
        return "";
    }
}