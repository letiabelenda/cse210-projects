public class EternalGoal : Goal
{
    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {

    }
    public override void RecordEvent(Quest quest)
    {
        
    }
    public override void SaveGoal(string fileName)
    {
         using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"EternalGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()}");
        }
    }
}