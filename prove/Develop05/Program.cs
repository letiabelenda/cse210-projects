using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        
        Quest quest = new Quest();
        
        do
        {
            Console.WriteLine($"You have {quest.GetTotalPoints()} points.");
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
                int choice = 0;

                Console.WriteLine("\nThe types of goals are:\n 1. Simple Goal \n 2. Eternal Goal\n 3. Checklist Goal");
                Console.WriteLine("Which type of goal do you like to create? ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {   
                    //create a SimpleGoal
                    SimpleGoal goal = new SimpleGoal("SimpleGoal", );
                }
                else if (choice == 2)
                {
                    //create an EternalGoal
                }
                else if (choice == 3)
                {
                    //create a ChecklistGoal
                }
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