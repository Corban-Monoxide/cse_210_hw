using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Swimming swimming = new Swimming("03 November 2021", 30, 25);
        Running running =  new Running("03 Novemeber 2021", 30, 5);
        Biking biking = new Biking("03 November 2021", 30, 15, 5);

        Console.WriteLine(swimming.GetSummary());
        Console.WriteLine("------------");
        Console.WriteLine(running.GetSummary());
        Console.WriteLine("------------");
        Console.WriteLine(biking.GetSummary());

        // List<Exercise> exercises;
        // foreach (var e in exercises)
        // {

        // }
    }
}