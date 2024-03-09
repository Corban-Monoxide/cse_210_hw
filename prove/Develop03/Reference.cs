public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    
    public Reference(string book_ref, int chapter_ref, int verse_ref)
    {
        book = book_ref;
        chapter = chapter_ref;
        verse = verse_ref;
    }

    public string DisplayReference()
    {
        string fullScripture = $"{book} {chapter}:{verse}";
        return fullScripture;
    }
}