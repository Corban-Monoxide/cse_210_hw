public class Swimming : Exercise
{
    private int _lapCount;
    public Swimming(string date, int time, int lapCount) : base(date, time)
    {
        this._lapCount = lapCount;
    }

    public (double distance, double speed, double pace) AmericanUnits()
    {
        double distance = ((_lapCount * 50) / (1000 * 0.62));
        double speed = (distance / _time) * 60;
        double pace = speed / 60;
        return (distance, speed, pace);
    }

    public override string GetSummary()
    {   (double distance, double speed, double pace) = AmericanUnits();
        Console.WriteLine("Swimming Summary:");
        return base.GetSummary() + $"Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile ";
    }
}
