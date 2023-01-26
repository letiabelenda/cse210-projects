using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        int option = 0;
        while (option != 5) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt.DisplayPrompt();
                Console.Write("> ");
                string answer = Console.ReadLine();
            }
        }
    }
}