public class Lecture : Event
{
    private int _capacity;
    private string _speaker;

    public Lecture(string eventTitle, string description, string date, string time, string address, int capacity, string speaker)
        : base(eventTitle, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }
    public void GetFullInfo()
    {
        Console.WriteLine("Full Info - ");
        Console.WriteLine($"Type of Event: Lecture \n");
        Console.WriteLine(StandardDisplay());
        Console.WriteLine($"Speaker: {_speaker}\n Capacity: {_capacity}");
    }

    public void GetShortInfo()
    {
        Console.WriteLine("Short Info - ");
        Console.Write($"Type of Event: Lecture \n");
        Console.WriteLine($"Event Title: {_eventTitle} \n Date: {_date}");
    }
    public override string StandardDisplay()
    {
        Console.WriteLine("Standard Info - ");
        return base.StandardDisplay();
    }
}