using System.Diagnostics.Contracts;

class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _feeling;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText}\nFeeling: {_feeling}");
    } 
}