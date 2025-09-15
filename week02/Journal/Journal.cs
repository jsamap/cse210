using System.IO;
class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            entry.Display();

    }
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
                outputFile.WriteLine($"{entry._date}-#-{entry._promptText}-#-{entry._entryText}-#-{entry._feeling}");
        }

    }
    public void LoadFromFile(string file)
    {
        string[] text = System.IO.File.ReadAllLines(file);
        foreach (string row in text)
        {
            string[] values = row.Split("-#-");
            Entry entry = new Entry();
            entry._date = values[0];
            entry._promptText = values[1];
            entry._entryText = values[2];
            entry._feeling = values[3];
            _entries.Add(entry);
        }
    }
}