public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string eventTitle, string description, string date, string time, string address, string weather)
        : base(eventTitle, description, date, time, address)
    {
        this._weather = weather;
    }

    public void GetFullInfo()
    {
        Console.WriteLine("Full Info - ");
        Console.WriteLine($"Type of Event: Outdoor Gathering\n");
        Console.WriteLine(StandardDisplay());
        Console.WriteLine($"Weather Forcast: {_weather}");
    }

    public void GetShortInfo()
    {
        Console.WriteLine("Short Info - ");
        Console.Write($"Type of Event: Outdoor Gathering\n");
        Console.WriteLine($"Event Title: {_eventTitle}\n Date: {_date}");
    }
    public override string StandardDisplay()
    {
        Console.WriteLine("Standard Info - ");
        return base.StandardDisplay();
    }
}