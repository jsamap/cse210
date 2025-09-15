// EXCEED REQUIREMENTS: Save other information in the journal entry. -Added a "feeling" field to the entry. 
using System;
using System.IO.Enumeration;
using System.Runtime.InteropServices;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        PromptGenerator generator = new PromptGenerator();
        generator._prompts = new List<string>();
        generator._prompts.Add("Who was the most interesting person I interacted with today?");
        generator._prompts.Add("What was the best part of my day?");
        generator._prompts.Add("How did I see the hand of the Lord in my life today?");
        generator._prompts.Add("What was the strongest emotion I felt today?");
        generator._prompts.Add("If I had one thing I could do over today, what would it be?");

        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        bool repeat = true;
        while (repeat)
        {
            Console.WriteLine(@"Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = generator.GetRandomPrompt();
                    Console.WriteLine(newEntry._promptText);
                    newEntry._entryText = Console.ReadLine();
                    Console.WriteLine("How are you feeling right now?");
                    newEntry._feeling = Console.ReadLine();

                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("What is the filename?");
                    string fileToLoad = Console.ReadLine();
                    journal.LoadFromFile(fileToLoad);
                    break;
                case "4":
                    Console.WriteLine("What is the filename?");
                    string fileToSave = Console.ReadLine();
                    journal.SaveToFile(fileToSave);
                    break;
                case "5":
                    Console.WriteLine();
                    repeat = false;
                    break;
                default:
                    Console.WriteLine("Enter a valid option...");
                    break;
            }

        }
    }
}