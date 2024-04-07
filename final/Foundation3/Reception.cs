public class Reception : Event
{
    private string _rsvp;
    public Reception(string eventTitle, string description, string date, string time, string address, string rsvp)
        : base(eventTitle, description, date, time, address)
    {
        this._rsvp = rsvp;
    }

    public void GetFullInfo()
    {
        Console.WriteLine("Full Info - ");
        Console.WriteLine($"Type of Event: Reception \n");
        Console.WriteLine(StandardDisplay());
        Console.WriteLine($"RSVP at {_rsvp}");
    }

    public void GetShortInfo()
    {
        Console.WriteLine("Short Info - ");
        Console.Write($"Type of Event: Reception \n");
        Console.WriteLine($"Event Title: {_eventTitle}\n Date: {_date}");
    }
    public override string StandardDisplay()
    {
        Console.WriteLine("Standard Info - ");
        return base.StandardDisplay();
    }

}