using System;
using System.Security.Cryptography.X509Certificates;

class Program
{   
    static public Journal journal;
    static void Main(string[] args)
    {
    Journal journal = new Journal();
        bool keepGoing = true;
        while (keepGoing)
        {
            var selection = ShowMenu();

            if (selection == 1)
            {
            // Prompt user with a random prompt
            var prompt = "This was a random prompt";
            // Read in user input
            var placeholderResponse = "This is what the user typed in";
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
                WriteFile(lines);
            }

            else if (selection == 4)
            {
                var lines = ReadFile();
                journal = new Journal(lines);
            }

            else if (selection == 5)
            {
                keepGoing = false;
            }
        }
    public string GetPrompt()
    {
        return "";
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
        string input = int.Parse(Console.ReadLine());
        return input;
    }

    static string[] SaveToFile()
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        return System.IO.File.ReadAllLines(filename);
    }

    static void LoadFromFile(string[] lines)
    {
        Console.Write("Enter filename: ");
        var filename = Console.ReadLine();
        System.IO.File.WriteAllLines(filename, lines);
    }
}
}