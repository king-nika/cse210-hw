using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();

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
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string prompt = parts[1];
            string response = parts[2];
            string date = parts[0];
            Entry entry = new Entry(prompt, response, date);
            _journal.Add(entry);
        }
    }
}