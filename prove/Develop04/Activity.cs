public class Activity {
    private string _activityName;
    private string _description;
    private int _duration;

    public Activity(string activityName, string description, int duration) {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName(){
        return _activityName;
    }
    public string GetDescription(){
        return _description;
    }
    public int GetDuration(){
        return _duration;
    }

    public void DisplayingStartingMessage(){
        Console.WriteLine($"Welcome to the {_activityName} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Int32.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get Ready...");

        var startTime = DateTime.UtcNow;

        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(5))
        {
             Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
    public void DisplayingEndingMessage(){
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity");

        var startTime = DateTime.UtcNow;

        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(5))
        {
             Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}