public class Listing : Activity
{
    private List<string> _prompts = new List<string>(){"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
    private List<string> _answers;
    public Listing():base()
    {
        _activityName = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 0;
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());

        string prompt = _prompts[index];

        Console.WriteLine("List as many responses you can to the following prompt");
        Console.WriteLine($"--- {prompt} ---");
        Console.Write("You may begin in: ");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine();
    }

    public void CountingItems()
    {
        var startTime = DateTime.UtcNow;
        _answers = new List<string>();

        while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(_duration))
        {
            Console.Write("> ");
            string answer = Console.ReadLine();
            _answers.Add(answer);
        }

        int numberAnswers = _answers.Count;
        Console.WriteLine($"You listed {numberAnswers} items!");
    }
}