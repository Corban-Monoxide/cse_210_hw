using System;

class Program
{
    static void Main(string[] args)
    {
int magicNumber;
int magicGuess;

        Random randomGenerator = new Random();
        magicNumber = randomGenerator.Next(1, 101);
        
        do {
        Console.WriteLine("What is your guess? ");
        string userGuess = Console.ReadLine();
        magicGuess = int.Parse(userGuess);

        
            if (magicNumber > magicGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < magicGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        
        } while (magicGuess != magicNumber);
    }
}