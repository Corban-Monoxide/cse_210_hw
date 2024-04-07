using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Lecture e1 = new Lecture("TedTalk", "Happiness", "Tomorrow", "11:11", "ABC-123 Sesame Street", 140, "Big Bird");
        Console.WriteLine(e1.StandardDisplay());
        Console.WriteLine("--------------------");
        e1.GetFullInfo();
        Console.WriteLine("--------------------");
        e1.GetShortInfo();
        Console.WriteLine("--------------------");

        Reception e2 = new Reception("Michael's Wedding", "Wedding", "Tonight", "5:00", "The White House", "wedding@gmail.com");
        Console.WriteLine(e2.StandardDisplay());
        Console.WriteLine("--------------------");
        e2.GetFullInfo();
        Console.WriteLine("--------------------");
        e2.GetShortInfo();
        Console.WriteLine("--------------------");


        OutdoorGathering e3 = new OutdoorGathering("Sports", "Hockey Game", "Next Week", "2:34", "My Home", "Snowy");
        Console.WriteLine(e3.StandardDisplay());
        Console.WriteLine("--------------------");
        e3.GetFullInfo();
        Console.WriteLine("--------------------");
        e3.GetShortInfo();
    }
}