public class Quest
{
    private List<Goal> _listGoals = new List<Goal>();
    private int _totalPoints;

    public Quest(List<Goal> listGoals)
    {
        _listGoals = listGoals;
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
    public void PrintList()
    {

    }
    public int CalculatePoints()
    {
        return 0;
    }
}