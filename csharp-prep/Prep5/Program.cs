using System;

class Program
{

    static void Main(string[] args)
    {
        DisplayWelcome();
        string Name = PromptUserName();
        int number = PromptUserNumber();
        int square_number = SquareNumber(number);
        DisplayResult(Name, square_number);

        
        // functions
        // return int
        // int Add2 (int number, string name)
        // {
        //     return number + 2;
        // }
        // // void
        // void PrintName(string name)
        // {
        //     System.Console.WriteLine(name);
        // }
        // int answer = Add2(10,"bob");
        // PrintName($"Bob is {answer}");
        // // Variable Scope
        // var i = 12;
        // {
        //     var y =10;
        //     y = i + 3;
        //     i = y + 4;
        // }
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World!");
        
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number?");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int userNumber)
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"The name is {name}, and your favoirte number squared is {squaredNumber}.");
    }
}