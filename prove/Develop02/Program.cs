using System;

class Program
{
    static void Main(string[] args)
    {
        string[] prompts = {
        "What was the highlight of your day?",
        "Describe a challenge you faced today.",
        "What are you grateful for today?",
        "Write about a goal you want to achieve.",
        "Reflect on a lesson you learned recently."
    };


        Journal journal = new Journal();
        bool keepGoing = true;
        while (keepGoing)
        {
            var selection = ShowMenu();

            if (selection == 1)
            {
                // Prompt user with a random prompt
                var prompt = GetPrompt();
                Console.WriteLine(prompt);
                // Read in user input
                var placeholderResponse = Console.ReadLine();
                var entry = new Entry(prompt, placeholderResponse);
                journal.AddEntry(entry);
            }

            else if (selection == 2)
            {
                journal.Display();
            }

            else if (selection == 3)
            {
                var lines = journal.Export();
                SaveToFile(lines);
            }

            else if (selection == 4)
            {
                var lines = LoadFromFile();
                journal = new Journal(lines);
            }

            else if (selection == 5)
            {
                keepGoing = false;
            }
        }

        string GetPrompt()
        {
        Random rand = new Random();
        int index = rand.Next(prompts.Length);
        return prompts[index];
        }

        static int ShowMenu()
        {
            Console.WriteLine("Journal System:");
            Console.WriteLine("1) Write ");
            Console.WriteLine("2) Display ");
            Console.WriteLine("3) Load ");
            Console.WriteLine("4) Save ");
            Console.WriteLine("5) Quit");

            Console.WriteLine("\nPlease make a choice: ");
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        static string[] LoadFromFile()
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            return System.IO.File.ReadAllLines(filename);
        }

        static void SaveToFile(string[] lines)
        {
            Console.Write("Enter filename: ");
            var filename = Console.ReadLine();
            System.IO.File.WriteAllLines(filename, lines);
        }
    }
}