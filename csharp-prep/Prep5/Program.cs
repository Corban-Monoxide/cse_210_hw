using System;

class Program
{
    static void Main(string[] args)
    {
        // functions
        // return int
        int Add2 (int number, string name)
        {
            return number + 2;
        }
        // void
        void PrintName(string name)
        {
            System.Console.WriteLine(name);
        }
        int answer = Add2(10,"bob");
        PrintName($"Bob is {answer}");
        // Variable Scope
        var i = 12;
        {
            var y =10;
            y = i + 3;
            i = y + 4;
        }
    }
}