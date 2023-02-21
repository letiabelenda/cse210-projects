using System;

class Program
{
    static void Main(string[] args)
    {   
        int option;

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {
                Breathing activity1 = new Breathing();
                activity1.DisplayingStartingMessage();
                activity1.RunBreathing();
                activity1.DisplayingEndingMessage();
            }
            else if (option == 2)
            {
                Reflecting activity2 = new Reflecting();
                activity2.DisplayingStartingMessage();
                activity2.DisplayRandomPrompt();
                activity2.Message();
                activity2.GetRandomQuestion();
                activity2.DisplayingEndingMessage();
            }
            else if (option == 3)
            {
                Listing activity3 = new Listing();
                Console.Clear();
                activity3.DisplayingStartingMessage();
                activity3.DisplayRandomPrompt();
                activity3.CountingItems();
                activity3.DisplayingEndingMessage();
            }
            

            
        }while(option != 4);
        
    }
}