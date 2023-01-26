public class PromptGenerator
{
    //public List<string> _prompts= new List<string>();
    public void DisplayPrompt()
    {
        var random = new Random();
        var prompts = new List<string>{"If I had one thing I could do over today, what would it be?,", "What was the best part of the day?", "Who was the most interesting person I interacted with today?", "How was the weather today?", "Is there anything I did today that I regret?", "In what ways did I serve someone today?"};
        int index = random.Next(prompts.Count) - 1;
        Console.WriteLine(prompts[index]);
    }
    
}