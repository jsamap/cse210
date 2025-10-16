using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        string filename = "save.txt";
        int totalPoints = 0;
        List<Goal> listOfGoals = new List<Goal>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"\nYou have {totalPoints} points.\n");
            Console.WriteLine("Menu options:");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            string option = Console.ReadLine();
            Console.Clear();

            switch (option)
            {
                case "1":
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("\t1. Simple Goal");
                    Console.WriteLine("\t2. Eternal Goal");
                    Console.WriteLine("\t3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    string type = Console.ReadLine();

                    string name = "";
                    string description = "";
                    int points = 0;
                    switch (type)
                    {
                        case "1":
                            Console.WriteLine("SIMPLE");
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            listOfGoals.Add(new SimpleGoal(name, description, points));
                            continue;
                        case "2":
                            Console.WriteLine("ETERNAL");
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            listOfGoals.Add(new EternalGoal(name, description, points));
                            continue;
                        case "3":
                            Console.WriteLine("CHECKLIST");
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int progressForBonus = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int bonusPoints = int.Parse(Console.ReadLine());
                            listOfGoals.Add(new ChecklistGoal(name, description, points, progressForBonus, bonusPoints));
                            continue;
                        default:
                            Console.WriteLine("Wrong option...");
                            break;
                    }
                    Thread.Sleep(3000);
                    continue;
                case "2":
                    Console.WriteLine("LIST");
                    GoalManager.DisplayGoals(listOfGoals);
                    Console.Write("\nPress enter to continue... ");
                    Console.ReadLine();
                    continue;
                case "3":
                    Console.WriteLine("SAVE");
                    GoalManager.SaveGoals(filename, totalPoints, listOfGoals);
                    Thread.Sleep(3000);
                    continue;
                case "4":
                    Console.WriteLine("LOAD");
                    (totalPoints, listOfGoals) = GoalManager.LoadGoals(filename);
                    Thread.Sleep(3000);
                    continue;
                case "5":
                    Console.WriteLine("RECORD");
                    Console.WriteLine("The goals are: ");
                    GoalManager.DisplayGoalNames(listOfGoals);
                    Console.Write("Which goal did you accomplish? ");
                    int goalIndex = int.Parse(Console.ReadLine()) - 1;
                    totalPoints += listOfGoals[goalIndex].Accomplish();
                    Thread.Sleep(3000);
                    continue;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please, enter a valid option...");
                    Thread.Sleep(3000);
                    continue;
            }
            break;
        }
    }
}