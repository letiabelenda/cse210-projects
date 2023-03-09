using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        int points = 0;
        
        do
        {
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Creat New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {

            }

            else if (option == 2)
            {
                
            }
            
            else if (option == 3)
            {
                
            }

            else if (option == 4)
            {
                
            }
            
            else if (option == 5)
            {
                
            }

        }while(option == 6);
    }
}