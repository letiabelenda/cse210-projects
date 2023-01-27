using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        int option = 0;
        while (option != 5) {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string option_sring = Console.ReadLine();
            option = int.Parse(option_sring);

            if (option == 1)
            {
                PromptGenerator prompt = new PromptGenerator();
                prompt.DisplayPrompt();
                Console.Write("> ");
                string answer = Console.ReadLine();
                journal.AddingAnEntry(prompt.GetPrompt(), answer);
            }

            else if (option == 2)
            {
                journal.DisplayAllTheEntries();
            }

            else if (option == 3)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                journal = new Journal();
                journal.LoadingFromAFile(fileName);
            }

            else if (option == 4)
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                journal.SavingToAFile(fileName);
            }
        }
    }
}