using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        while (true)
        {
        Console.Clear();
        Console.WriteLine(reference.DisplayReference());
        scripture.DisplayScripture();

        Console.Write("\nPress Enter to hide more words, or type 'quit' to finish. ");
        string input = Console.ReadLine();
        if (input == "quit")
        {
            break;
        }
        scripture.DisplayHidden(5);
        }
    }
}