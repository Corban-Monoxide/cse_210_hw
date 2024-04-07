
public class Running : Exercise
{
    private int _distance;

    public Running(string date, int time, int distance) : base(date, time)
    {
        this._distance = distance;
    }

    public (double speed, double pace) AmericanUnits()
    {
        double speed = _distance / (_time / 60.0); // Convert time to hours
        double pace = _time / _distance; // Calculate pace in minutes per mile
        return (speed, pace);
    }

    public override string GetSummary()
    {
        (double speed, double pace) = AmericanUnits();
        Console.WriteLine("Running Summary:");
        return base.GetSummary() + $"Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile ";
    }
}
