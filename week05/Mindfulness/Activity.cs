class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!\n");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        int ms = 125;
        string bs = "\b \b";
        int counter = 0;
        while (counter < seconds)
        {
            counter++;
            Console.Write("—");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("\\");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("|");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("/");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("—");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("\\");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("|");
            Thread.Sleep(ms);
            Console.Write(bs);

            Console.Write("/");
            Thread.Sleep(ms);
            Console.Write(bs);
        }
    }
    public void ShowCountDown(int seconds)
    {
        string bs = "\b \b";
        while (seconds > 0)
        {
            Console.Write(bs + seconds.ToString());
            Thread.Sleep(1000);
            seconds--;
        }
        Console.Write(bs);
    }
    public int GetDuration()
    {
        return _duration;
    }
}