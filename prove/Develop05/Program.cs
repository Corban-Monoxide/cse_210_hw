using System;

class Program
{
    static void Main(string[] args)
    {
        bool finish = false;
        do
        {
            Console.Clear();
            List<Goal> allGoals = new List<Goal>();
            var selection = ShowMenu();
            if (selection == 1)
            {
                Console.WriteLine("What kind of goal would you like to make?");
                Console.WriteLine("1) Simple Goal");
                Console.WriteLine("2) Checklist Goal");
                Console.WriteLine("3) Eternal Goal");
                int goalInput = int.Parse(Console.ReadLine());
                if (goalInput == 1)
                {
                    var goal = new SimpleGoal();
                    allGoals.Add(goal);
                }
                else if (goalInput == 2)
                {
                    var goal = new ChecklistGoal();
                    allGoals.Add(goal);
                }
                else if (goalInput == 3)
                {
                    var goal = new EternalGoal();
                    allGoals.Add(goal);
                }
            }
            else if (selection == 2) // List Goals, my goals aren't displaying
            {
                Console.WriteLine("\nGoals: ");
                foreach (var goals in allGoals)
                {
                    Console.WriteLine(goals);
                }
                Console.WriteLine("Press a key to continue ");
                Console.ReadKey();
            }

            else if (selection == 3) // Save Goals
            {
                //WritePeople
                Console.WriteLine("What file name would you like?");
                string filename = Console.ReadLine();
                Files.Save(filename, allGoals);
            }

            else if (selection == 4) // Load Goals
            {
                //ReadPeople
                // Files.Load();
            }
            else if (selection == 5) //Record Event
            {

            }
            else if (selection == 6) // Quit
            {
                finish = true;
            }
        } while (finish != true);
    }
    public static int ShowMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1) Create New Goal");
        Console.WriteLine("2) List Goals");
        Console.WriteLine("3) Save Goals");
        Console.WriteLine("4) Load Goals");
        Console.WriteLine("5) Record Event");
        Console.WriteLine("6) Quit");

        int input = int.Parse(Console.ReadLine());
        return input;
    }
}