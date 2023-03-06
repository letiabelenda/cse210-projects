public class ChecklistGoal : Goal
{
    private int _counter;
    private int _times;
    private int _bonus;
    private Boolean _isComplete;

    public ChecklistGoal(string type, string name, string description, in points, int times) : base(type, name, description, points)
    {

    }

    public void SetCounter()
    {

    }
    public Boolean SetIsComplete()
    {
        return _isComplete = false;
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

    public override void SaveFile()
    {
        base.SaveFile();
    }
    public Boolean IsComplete()
    {
        return _isComplete = true;
    }
    public override void RecordEvent()
    {
        base.RecordEvent();
    }

}