public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }
    public override void RecordEvent(Quest quest)
    {
        Console.WriteLine($"Congratulations! You have earned {this.GetPoints()} points!");
    }
    public override void SaveGoal(StreamWriter outputFile)
    {
        outputFile.WriteLine($"EternalGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()}");
    }
}