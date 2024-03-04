public class Journal
{
    public List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }
    public Journal(string[] imports)
    {
        entries = new List<Entry>();
        foreach (var import in imports)
        {
            var enter = new Entry(import);
            entries.Add(enter);
        }
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void Display()
    {
        Console.WriteLine("\nEntries: ");
        foreach (var enter in entries)
        {
            Console.WriteLine(enter.DisplayString());
        }
        Console.WriteLine("Press a key to continue ");
        Console.ReadKey();
    }
    public string[] Export()
    {
        var exportLines = new List<string>();
        foreach (var enter in entries)
        {
            exportLines.Add(enter.Export());
        }
        return exportLines.ToArray();
    }
}