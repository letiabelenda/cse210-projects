public class Goal
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

    public virtual void RecordEvent()
    {
        
    }
    public void LoadFile()
    {

    }
    public virtual void SaveFile()
    {

    }



}