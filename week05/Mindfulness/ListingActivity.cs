class ListingActivity : Activity{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(int count, List<string> prompts) : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
        0)
    {
        _count = count;
        _prompts = prompts;
    }
    public void Run()
    {
        Console.Write("Get ready... ");
        ShowSpinner(5);
        Console.WriteLine("\n\nList as many responses you can to the following prompt:\n");
        GetRandomPrompt();
        
        Console.Write("\nYou may begin in:  ");
        ShowCountDown(5);
        Console.WriteLine("\n");
        DateTime endDateTime = DateTime.Now.AddSeconds(_duration);
        List<string> listedItems = new List<string>();
        while (DateTime.Now < endDateTime)
        {
            Console.Write("> ");
            listedItems.Add(Console.ReadLine());
        }
        Console.WriteLine($"You listed {listedItems.Count} items.");
    }
    public void GetRandomPrompt()
    {
        Console.WriteLine($" --- {_prompts[new Random().Next(0, _prompts.Count - 1)]} ---");
    }
    public List<string> GetListFromUser()
    {

        return new List<string>();
    }
}