public class EternalGoal : Goal
{
    private Boolean _isComplete;

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }

    public Boolean SetIsComplete()
    {
        return _isComplete = false;
    }
}