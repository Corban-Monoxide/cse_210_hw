// public abstract class Goal
// {
//     private int _pointValue;
//     private string _description;
//     private string _name;
//     public Goal()
//     {
//         Console.WriteLine("What is the name of the goal? ");
//         _name = Console.ReadLine();
//         Console.WriteLine("Give a short description of it: ");
//         _description = Console.ReadLine();
//         Console.WriteLine("How many points do you want to assign to this goal? ");
//         _pointValue = int.Parse(Console.ReadLine());
//     }

//     public int RecordEvent()
//     {
//         return 0;
//     }
//     public bool CompleteGoals() // make virtual
//     {
//         return true;
//     }
//     public void DisplayGoals() // make virtual
//     {
        
//     }
//     public virtual string Export()
//     {
        
//     }
// }
public abstract class Goal
{
    private int _pointValue;
    private string _description;
    private string _name;

    public Goal()
    {
        Console.WriteLine("What is the name of the goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("Give a short description of it: ");
        _description = Console.ReadLine();
        Console.WriteLine("How many points do you want to assign to this goal? ");
        _pointValue = int.Parse(Console.ReadLine());
    }

    public int RecordEvent()
    {
        return 0;
    }

    public bool CompleteGoals()
    {
        return true;
    }

    public virtual void DisplayGoals()
    {

    }

    public virtual string Export()
    {
        return "";
    }

    public override string ToString()
    {
        return $"{_name}: {_description}, Points: {_pointValue}";
    }
}