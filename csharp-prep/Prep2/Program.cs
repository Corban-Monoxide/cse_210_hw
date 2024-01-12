using System;

class Program
{
    static void Main(string[] args)
    {
        // This is prep 2
        Console.Write("What is your final grade? ");
        string UserInput = Console.ReadLine();
        int FinalGrade = int.Parse(UserInput);

        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        if (FinalGrade >= A)
        {
            Console.Write("You got an A! ");
        }
        else if (A > FinalGrade && FinalGrade >= B )
        {
            Console.Write("You got a B! ");
        }
        else if (B > FinalGrade && FinalGrade >= C)
        {
            Console.Write("You got a C! ");
        }
        else if (C > FinalGrade && FinalGrade >= D)
        {
            Console.Write("You got a D. ");
        }
        else
        {
            Console.Write("You got an F. ");
        }


        if (FinalGrade >= C)
        {
            Console.Write("You also got a passing grade! ");
        }
        else
        {
            Console.Write("You did not pass. ");
        }
        
    }
}