
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;


    public Entry(string prompt, string entry, string date)
    {
        _promptText = prompt;
        _entryText = entry;
        _date = date;
    }


    public void Display()
    {
        Console.WriteLine($"Date: {_date} Prompt: {_promptText} Entry: {_entryText}");
    }
}

