public class Scripture
{
    private List<Word> words;
    public Scripture(string script)
    {
        words = new List<Word>();
        var parts = script.Split(" ");
        foreach (var part in parts)
        {
            Word word =  new Word(part);
            words.Add(word);
        }
    }
    public void DisplayScripture()
    {
    foreach (var word in words)
    {
        if (word.IsHidden)
        {
            Console.Write(word.DisplayReference());
        }
        else
        {
            Console.Write(word.Display());
        }
    }
    }
    public void DisplayHidden(int numberWords)
    {
        Random random = new Random();
        for (int i = 0; i < numberWords; i++)
        {
            int wordsIndex = random.Next(words.Count);
            words[wordsIndex].IsHidden = true;
        }
    }
}