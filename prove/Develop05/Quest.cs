public class Quest
{
    private List<Goal> _listGoals = new List<Goal>();
    private int _totalPoints;

    public Quest()
    {
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _listGoals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public List<Goal> GetListGoals()
    {
        return _listGoals;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public void ListGoals()
    {   
        int index = 1;
        Console.WriteLine("The goals are: ");
        
        foreach (Goal goal in _listGoals)
        {   
            if (goal.GetTypeGoal() == "SimpleGoal")
            {
                SimpleGoal simpleGoal = goal as SimpleGoal;
                if (simpleGoal.IsCompleted())
                {
                    Console.WriteLine($"{index}. [X] {goal.GetName()} ({goal.GetDescription()})");
                }
                else
                {
                    Console.WriteLine($"{index}. [ ] {goal.GetName()} ({goal.GetDescription()})");
                }
                
            }
            else if (goal.GetTypeGoal() == "EternalGoal")
            {
                Console.WriteLine($"{index}. [ ] {goal.GetName()} ({goal.GetDescription()})");
            }
            else 
            {
                ChecklistGoal checklistGoal = goal as ChecklistGoal;
                if (checklistGoal.IsCompleted())
                {
                    Console.WriteLine($"{index}. [X] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {checklistGoal.GetCounter().ToString()}/{checklistGoal.GetTimes().ToString()}");
                }
                
                else 
                {
                    Console.WriteLine($"{index}. [ ] {goal.GetName()} ({goal.GetDescription()}) -- Currently completed: {checklistGoal.GetCounter().ToString()}/{checklistGoal.GetTimes().ToString()}");
                }
            }

            index = index + 1;
        }
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void LoadFile(string fileName)
    {
        string[] goals = System.IO.File.ReadAllLines(fileName);
        int totalPoints = Int32.Parse(goals[0]);
        this.SetTotalPoints(totalPoints);

        goals = goals.Skip(1).ToArray();
    
        foreach (string goal in goals)
        {
            string[] parts = goal.Split(",");
            string[] firstPart = parts[0].Split(":");

            if (firstPart[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]), bool.Parse(parts[3]));
                this.AddGoal(simpleGoal);
            }
            else if (firstPart[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]));
                this.AddGoal(eternalGoal);
            }
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4]), Int32.Parse(parts[5]));
                this.AddGoal(checklistGoal);
            }

        }
    }
     public void SaveFile()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{this.GetTotalPoints()}");
            foreach (Goal goal in _listGoals)
            {
                goal.SaveGoal(outputFile);
            }
        }       
    }
}