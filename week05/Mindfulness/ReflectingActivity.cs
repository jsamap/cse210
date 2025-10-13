class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(List<string> prompts, List<string> questions) : base("Reflecting Activity",
    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
    0)
    {
        _prompts = prompts;
        _questions = questions;
    }
    public void Run()
    {
        Console.Write("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine("\n\nConsider the following prompt: \n");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they as they relate to this experience.");
        Console.Write("You may begin in:  ");
        ShowCountDown(5);
        
        Console.Clear();
        DateTime endDateTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endDateTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
            Console.WriteLine();
        }
    }

    public string GetRandomPrompt()
    {
        return _prompts[new Random().Next(0, _prompts.Count-1)];
    }
    public string GetRandomQuestion()
    {
        return _questions[new Random().Next(0, _questions.Count-1)];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
    }
    public void DisplayQuestion()
    {
        Console.Write($" > {GetRandomQuestion()} ");
    }
}