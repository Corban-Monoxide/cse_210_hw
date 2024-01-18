using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    { 
    List<int> numbers = new List<int>();
    int numberOfInputs = 0;
    int total = 0;
    int userNumber = 0;
    int average = 0;
    Console.WriteLine("Enter a list of numbers. Type 0 when you are finished.");
    do 
    {
        Console.WriteLine("Enter a number: ");
        string userInput = Console.ReadLine();
        userNumber = int.Parse(userInput);
        if (userNumber !=  0)
        {
            numbers.Add(userNumber);
            total += userNumber;
            numberOfInputs += 1;
        }
    } while (userNumber != 0);

    Console.WriteLine($"The total is {total}.");

    average = total/numberOfInputs;
    Console.WriteLine($"The average is {average}.");

    int largestNumber = numbers.Max();
    Console.WriteLine($"The largest number in the list is {largestNumber}.");

        // Lists - new keyword
        // List <int> MyInts = new List<int>();
        // var otherInts = new List<int>();

        // // Add items
        // MyInts.Add(10);
        // MyInts.Add(3); //Don't add floats becasue we already specified it's an int list
        // MyInts.Add(45);

        // // Iterate over items
        // foreach (var n in MyInts)
        // {
        //     System.Console.WriteLine($"n = {n}");
        // }



        // Console.WriteLine("Hello Prep4 World!");
    }
}