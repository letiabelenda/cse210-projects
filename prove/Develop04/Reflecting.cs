public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>(){"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _questions = new List<string>(){"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};

    public Reflecting():base()
    {
        _activityName = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _duration = 0;
    }

    public void DisplayRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count());

        string prompt = _prompts[index];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        while (Console.ReadKey().Key != ConsoleKey.Enter) {}
    }

    public void Message()
    {
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
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

        Console.Clear();
    }

    public void GetRandomQuestion()
    {
        int num = _duration/10;
        int times = 0;
        
        List<string> questions = new List<string>(_questions.Count);

        _questions.ForEach((item) =>
        {
            questions.Add((string)item.Clone());
        });

        while(times < num && questions.Count() != 0)
        {
            Random random = new Random();
            int index = random.Next(questions.Count());

            string question = questions[index];
            questions.Remove(question);
            
            Console.WriteLine($"> {question}");

            var startTime = DateTime.UtcNow;

            while(DateTime.UtcNow - startTime < TimeSpan.FromSeconds(10))
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
            
            times = times + 1;
        }
    }   
}