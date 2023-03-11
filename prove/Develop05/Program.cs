using System;

class Program
{
    static void Main(string[] args)
    {
        int option;
        
        Quest quest = new Quest();
        
        do
        {
            Console.WriteLine();
            Console.WriteLine($"You have {quest.GetTotalPoints()} points.");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
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
                Console.Write("Which type of goal do you like to create? ");
                choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {   
                    //create a SimpleGoal
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal("SimpleGoal", name, description, points);
                    quest.AddGoal(goal);
                }
                else if (choice == 2)
                {
                    //create an EternalGoal
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal("EternalGoal", name, description, points);
                    quest.AddGoal(goal);
                }
                else if (choice == 3)
                {
                    //create a ChecklistGoal
                    Console.Write("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int times = Int32.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = Int32.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal("ChecklistGoal", name, description, points, times, bonus);
                    quest.AddGoal(goal);
                }
            }

            else if (option == 2)
            {
                quest.ListGoals();
            }
            
            else if (option == 3)
            {
                quest.SaveFile();
            }

            else if (option == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                quest = new Quest();

                quest.LoadFile(fileName);
            }
            
            else if (option == 5)
            {
                int number = 1;

                Console.WriteLine("The goals are:");

                foreach (Goal goal in quest.GetListGoals())
                {
                    Console.WriteLine($"{number}. {goal.GetName()}");
                    number = number + 1;
                }
                
                Console.Write("Which goal did you accomplished? ");
                int answer = Int32.Parse(Console.ReadLine());

                int points = quest.GetListGoals()[answer - 1].GetPoints();

                quest.AddPoints(points);

                quest.GetListGoals()[answer - 1].RecordEvent(quest);
                Console.WriteLine($"You now have {quest.GetTotalPoints()} points.");

            }

        }while(option != 6);
    }
}