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
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());

                    SimpleGoal goal = new SimpleGoal("SimpleGoal", name, description, points);
                }
                else if (choice == 2)
                {
                    //create an EternalGoal
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());

                    EternalGoal goal = new EternalGoal("EternalGoal", name, description, points);
                }
                else if (choice == 3)
                {
                    //create a ChecklistGoal
                    Console.WriteLine("What is the name of your goal? ");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is a short description of it? ");
                    string description = Console.ReadLine();
                    Console.WriteLine("What is the amount of points associated with this goal? ");
                    int points = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                    int times = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                    int bonus = Int32.Parse(Console.ReadLine());

                    ChecklistGoal goal = new ChecklistGoal("ChecklistGoal", name, description, points, times, bonus);
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
                int number = 0;

                Console.Write("The goals are:");

                foreach (Goal goal in quest.GetListGoals())
                {
                    Console.WriteLine($"{number + 1}. {goal.GetName}");
                }

                Console.WriteLine("Which goal did you accomplished? ");
                int answer = Int32.Parse(Console.ReadLine());

                int points = quest.GetListGoals()[answer - 1].GetPoints();

                Console.WriteLine($"Congratulations! You have earned {points} points!");

                quest.AddPoints(points);

                quest.GetListGoals()[answer - 1].RecordEvent(quest);

                Console.WriteLine($"You now have {quest.GetTotalPoints()} points.");

            }

        }while(option == 6);
    }
}