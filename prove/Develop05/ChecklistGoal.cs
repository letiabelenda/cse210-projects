public class ChecklistGoal : Goal
{
    private int _counter;
    private int _times;
    private int _bonus;
    private Boolean _isComplete;

    public ChecklistGoal(string type, string name, string description, int points, int times, int bonus) : base(type, name, description, points)
    {
        _isComplete = false;
        _times = times;
        _counter = 0;
        _bonus = bonus;
    }

    public void SetCounter()
    {
        _counter += _counter;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public int GetCounter()
    {
        return _counter;
    }
    public int GetTimes()
    {
        return _times;
    }

    public override void RecordEvent(Quest quest)
    {
       _isComplete = true;
       
    }
    public override void SaveFile()
    {
        base.SaveFile();
    }

}