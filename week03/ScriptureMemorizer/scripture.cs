using System;
using System.ComponentModel;


public class Scripture
{

    Reference _reference;

    private List<Word> _words = new List<Word>();

    private Random _random = new Random();

    public Scripture(Reference reference, string Text)
    {
        _reference = reference;
        string[] words = Text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }




    public void hideRandomWords(int numberToHide)
    {

        for (int i = 0; i < numberToHide; i++)
            {
                int hidden = _random.Next(_words.Count);
                _words[hidden].Hide();
            }
    }


    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }

        string newText = string.Join(" ", displayWords);


        return $"{_reference} {newText}";
    }
    
    public bool IsCompltlyHidden()
    {
        foreach (var word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}