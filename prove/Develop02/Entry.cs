public class Entry
{
    public string response;
    public string prompt;
    public Entry (string response , string prompt)
    {
        this.response = response;
        this.prompt = prompt;
    }
    public Entry (string import);
    {
        var En = import.Split("_");
        this.response = En[0];
        this.prompt = En[1];
    }

    public string Export();
    {
        return $"{response}_{prompt}";
    }

    public string DisplayString();
    {
        return $"{response} {prompt}";
    }
}