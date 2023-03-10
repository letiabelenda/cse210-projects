public class SimpleGoal : Goal
{
    private Boolean _isComplete;

    public SimpleGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string type, string name, string description, int points, Boolean isComplete) : base(type, name, description, points)
    {
        _isComplete = isComplete;
    }

    public Boolean IsCompleted()
    {
        return _isComplete;
    }
    public override void RecordEvent(Quest quest)
    {
       _isComplete = true;
       Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points!");
    }
    public override void SaveGoal(StreamWriter outputFile)
    {

        outputFile.WriteLine($"SimpleGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{this.IsCompleted()}");

    }

}