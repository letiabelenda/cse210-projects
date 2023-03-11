public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }
    public override void RecordEvent(Quest quest)
    {

    }
    public override void SaveFile()
    {
        throw new NotImplementedException();
    }
}