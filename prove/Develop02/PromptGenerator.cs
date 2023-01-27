public class PromptGenerator
{
    string _prompt;
    public void DisplayPrompt()
    {
        var random = new Random();
        var prompts = new List<string>{"If I had one thing I could do over today, what would it be?", "What was the best part of the day?", "Who was the most interesting person I interacted with today?", "How was the weather today?", "Is there anything I did today that I regret?", "In what ways did I serve someone today?", "Did i meet someone new today?", "What did I learn today that I didn't know before?", "What was my favorite Scripture of the day?", };
        int index = random.Next(prompts.Count);

        Console.WriteLine(prompts[index]);
        
        _prompt = prompts[index];

    }

    public string GetPrompt() {
        return _prompt;
    }
    
}