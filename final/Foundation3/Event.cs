public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;


    public Event(string eventTitle, string description, string date, string time, string address)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public virtual string StandardDisplay()
    {
        return $"{_eventTitle}:\n Description: {_description}\n Address: {_address}\n Date: {_date}\n Time: {_time}";
    }
}