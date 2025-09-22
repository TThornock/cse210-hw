using System;
using System.IO;
using System.Net.Http.Headers;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void Displayall()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date} Prompt: {entry._promptText} Entry: {entry._entryText}");
            }
            Console.WriteLine($"Saving to: {Path.GetFullPath(file)}");
        }
    }

    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            string[] parts = line.Split(new[] { "date: ", " Prompt: ", " Entry: " }, StringSplitOptions.None);
            if (parts.Length == 4)
            {
                string date = parts[1];
                string prompt = parts[2];
                string entryText = parts[3];

                _entries.Add(new Entry(date, prompt, entryText));
            }
        }          

 
    }
}
        
   