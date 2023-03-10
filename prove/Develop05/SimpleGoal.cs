public class SimpleGoal : Goal
{
    private Boolean _isComplete;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent(Quest quest)
    {
       _isComplete = true;
    }

}