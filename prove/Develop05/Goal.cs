public abstract class Goal
{
    protected string _type;
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string type, string name, string description, int points)
    {
        _type = type;
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetTypeGoal()
    {
        return _type;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public abstract void RecordEvent(Quest quest);

    public void LoadFile(string fileName, Quest quest)
    {
        string[] goals = System.IO.File.ReadAllLines(fileName);
        int totalPoints = Int32.Parse(goals[0]);
        quest.SetTotalPoints(totalPoints);

        goals = goals.Skip(1).ToArray();
    
        foreach (string goal in goals)
        {
            string[] parts = goal.Split(", ");
            string[] firstPart = parts[0].Split(":");

            if (firstPart[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]), bool.Parse(parts[3]));
                quest.AddGoal(simpleGoal);
            }
            else if (firstPart[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]));
                quest.AddGoal(eternalGoal);
            }
            else
            {
                ChecklistGoal checklistGoal = new ChecklistGoal(firstPart[0], firstPart[1], parts[1], Int32.Parse(parts[2]), Int32.Parse(parts[3]), Int32.Parse(parts[4]), Int32.Parse(parts[5]));
                quest.AddGoal(checklistGoal);
            }

        }

    }
    public abstract void SaveFile();




}