using System;

public class Word
{
    private string word;
    public bool IsHidden;
    public Word(string word)
    {
        this.word = word;
        IsHidden = false;
    }
    public string Display()
    {
        {
        return word + " ";
        }
    }

    public string Text => word;
    public string DisplayReference() => IsHidden ? "____": Text;
}