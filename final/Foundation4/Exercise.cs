public class Exercise
{
    protected string _date;
    protected int _time; // in minutes

    public Exercise(string date, int time)
    {
        this._date = date;
        this._time =  time;

    }
    public virtual string GetSummary()
    {
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        // 03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.6 kph, Pace: 6.25 min per km
        return $"{_date} for {_time} minutes - ";
    }
}