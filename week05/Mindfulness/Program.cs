// EXCEEDING REQUIREMENTS: Keeping a log of how many times activities were performed (and the total time for each type of activity).

using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> tracker = new Dictionary<string, List<int>>();
        tracker["breathing"] = new List<int>() { 0, 0 };
        tracker["reflecting"] = new List<int>() { 0, 0 };
        tracker["listing"] = new List<int>() { 0, 0 };

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Show activity record");
            Console.WriteLine("\t5. Quit");
            Console.Write("Select a choice from the menu: ");

            string option = Console.ReadLine();
            Console.Clear();
            switch (option)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.DisplayStartingMessage();
                    Console.Clear();
                    breathingActivity.Run();
                    breathingActivity.DisplayEndingMessage();

                    tracker["breathing"][0] = tracker["breathing"][0] + 1;
                    tracker["breathing"][1] = tracker["breathing"][1] + breathingActivity.GetDuration();
                    continue;
                case "2":
                    List<string> prompts = new List<string>(){
                        "Think of a time when you stood up for someone else.",
                        "Think of a time when you did something really difficult.",
                        "Think of a time when you helped someone in need.",
                        "Think of a time when you did something truly selfless."
                    };
                    List<string> questions = new List<string>(){
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?"
                    };
                    ReflectingActivity reflectingActivity = new ReflectingActivity(prompts, questions);
                    reflectingActivity.DisplayStartingMessage();
                    Console.Clear();
                    reflectingActivity.Run();
                    reflectingActivity.DisplayEndingMessage();

                    tracker["reflecting"][0] = tracker["reflecting"][0] + 1;
                    tracker["reflecting"][1] = tracker["reflecting"][1] + reflectingActivity.GetDuration();
                    continue;
                case "3":
                    List<string> promptsList = new List<string>(){
                        "Who are people that you appreciate?",
                        "What are personal strengths of yours?",
                        "Who are people that you have helped this week?",
                        "When have you felt the Holy Ghost this month?",
                        "Who are some of your personal heroes?"
                    };
                    ListingActivity listingActivity = new ListingActivity(0, promptsList);
                    listingActivity.DisplayStartingMessage();
                    Console.Clear();
                    listingActivity.Run();
                    listingActivity.DisplayEndingMessage();

                    tracker["listing"][0] = tracker["listing"][0] + 1;
                    tracker["listing"][1] = tracker["listing"][1] + listingActivity.GetDuration();
                    continue;
                case "4":
                    Console.WriteLine($"Breathing activity ran {tracker["breathing"][0]} times for a total of {tracker["breathing"][1]} seconds.");
                    Console.WriteLine($"Reflecting activity ran {tracker["reflecting"][0]} times for a total of {tracker["reflecting"][1]} seconds.");
                    Console.WriteLine($"Listing activity ran {tracker["listing"][0]} times for a total of {tracker["listing"][1]} seconds.");
                    Console.WriteLine("\nPress enter to continue...");
                    Console.ReadLine();
                    continue;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please, enter a valid option...");
                    continue;
            }
            break;
        }

    }
}