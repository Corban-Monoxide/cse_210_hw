public class Biking : Exercise
{
    private int _speed;
    private int _distance;

    public Biking(string date, int time, int speed, int distance) : base(date, time)
    {
        this._speed = speed;
        this._distance = distance;
    }

    public (double speed, double pace) AmericanUnits()
    {
        double speed = _speed;
        double pace = 60.0 / speed; // Calculate pace in minutes per mile
        return (speed, pace);
    }

    public override string GetSummary()
    {
        (double speed, double pace) = AmericanUnits();
        Console.WriteLine("Biking Summary:");
        return base.GetSummary() + $"Distance: {_distance} miles, Speed: {speed} mph, Pace: {pace} min per mile ";
    }
}
