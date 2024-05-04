using System;
public class Entry
{
    public string _promtText;
    public string _entryText;
    public string _entryDate;

        public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate} - Promt: {_promtText}");
        Console.WriteLine($"{_entryText}");
    }
}


