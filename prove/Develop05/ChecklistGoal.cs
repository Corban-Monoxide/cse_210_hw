public class ChecklistGoal:Goal
{
    private int amountCompleted;
    private int bonus;
    private int timesNeededComplete;
    public ChecklistGoal():base()
    {
        Console.WriteLine("How many times do you have to complete this goal?");
        timesNeededComplete = int.Parse(Console.ReadLine());
        Console.WriteLine("How many extra points do you get if you complete the goal? ");
        bonus = int.Parse(Console.ReadLine());
    }
}