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
    public ChecklistGoal(string type, string name, string description, int points, int bonus, int times, int counter) : base(type, name, description, points)
    {
        _isComplete = false;
        _times = times;
        _counter = counter;
        _bonus = bonus;
    }


    public void SetCounter()
    {
        _counter = _counter + 1;
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
    public Boolean IsCompleted()
    {
        return _isComplete;
    }
    public override void RecordEvent(Quest quest)
    {
        this.SetCounter();

       int points = _points;

        if (_counter == _times)
        {
            _isComplete = true;
            quest.AddPoints(_bonus);
            points = points + _bonus;
        }

        Console.WriteLine($"Congratulations! You have earned {points} points!");


    }
    public override void SaveGoal(StreamWriter outputFile)
    {

        outputFile.WriteLine($"ChecklistGoal:{this.GetName()},{this.GetDescription()},{this.GetPoints()},{this.GetBonus()},{this.GetTimes()},{this.GetCounter()}");

    }

}