class GoalManager
{
    public static void DisplayGoals(List<Goal> listOfGoals)
    {
        for (int i = 0; i < listOfGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listOfGoals[i].GetDisplayText()}");
        }
    }
    public static void DisplayGoalNames(List<Goal> listOfGoals)
    {
        for (int i = 0; i < listOfGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {listOfGoals[i].GetName()}");
        }
    }
    public static void SaveGoals(string filename, int totalPoints, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in goals)
                outputFile.WriteLine(goal.GetTextToSave());
        }
    }
    public static (int, List<Goal>) LoadGoals(string filename)
    {
        int totalPoints = 0;
        List<Goal> listOfGoals = new List<Goal>();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (Array.IndexOf(lines, line) == 0)
            {
                totalPoints = int.Parse(line.Trim());
            }
            else
            {
                string[] parts = line.Split("##");
                switch (parts[0])
                {
                    case "SimpleGoal":
                        listOfGoals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        continue;
                    case "EternalGoal":
                        listOfGoals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        continue;
                    case "ChecklistGoal":
                        listOfGoals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), bool.Parse(parts[7])));
                        continue;
                }
            }
        }

        return (totalPoints, listOfGoals);
    }
}