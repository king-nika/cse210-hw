using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _journal = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _journal.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        string jsonString = JsonSerializer.Serialize(_journal, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filename, jsonString);
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string jsonString = File.ReadAllText(filename);
            _journal = JsonSerializer.Deserialize<List<Entry>>(jsonString) ?? new List<Entry>();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
