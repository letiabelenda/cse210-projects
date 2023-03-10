public class Quest
{
    private List<Goal> _listGoals = new List<Goal>();
    private int _totalPoints;

    public Quest()
    {
        _totalPoints = 0;
    }

    public void AddSimpleGoal(SimpleGoal goal)
    {
        _listGoals.Add(goal);
    }
    public void AddEternalGoal(EternalGoal goal)
    {
        _listGoals.Add(goal);
    }
    public void AddChecklistGoal(ChecklistGoal goal)
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
        foreach (Goal goal in _listGoals)
        {   
            if (goal.GetTypeGoal() == "SimpleGoal")
            {
                //imprimir la simpleGoal como en el video
                Console.WriteLine();
            }
            else if (goal.GetTypeGoal() == "EternalGoal")
            {
                Console.WriteLine(); //imprimir Eternal Goal como en el video
            }
            else 
            {
                Console.WriteLine(); //imprimir Checklist como en el video
            }
        }
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
}