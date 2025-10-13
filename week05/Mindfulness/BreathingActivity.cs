class BreathingActivity : Activity {

    public BreathingActivity() : base("Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear you mind and focus on your breathing.",
        0) { }

    public void Run()
    {
        Console.Write("Get ready... ");
        ShowSpinner(5);
        
        DateTime endDateTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endDateTime)
        {
            Console.Write("\n\nBreathe in...  ");
            ShowCountDown(4);
            Console.Write("\nBreathe out...  ");
            ShowCountDown(6);
        }
    }
}