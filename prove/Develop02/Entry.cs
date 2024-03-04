public class Entry
{
    public string response;
    public string prompt;
    public string date;
    public Entry (string response , string prompt)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        this.response = response;
        this.prompt = prompt;
        this.date = $"{dateText}";
    }
    public Entry (string import)
    {
        var En = import.Split("_");
        this.response = En[0];
        this.prompt = En[1];
        this.date = En[2];
    }

    public string Export()
    {
        return $"{response}_{prompt}_{date}";
    }

    public string DisplayString()
    {
        return $"{response} {prompt} {date}";
    }
}