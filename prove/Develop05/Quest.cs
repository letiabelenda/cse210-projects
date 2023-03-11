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
    public void ListGoals()
    {   
        int index = 1;

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
}