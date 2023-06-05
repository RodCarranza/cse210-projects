using System;
using System.IO; //File
using System.Collections.Generic;
using System.Text.Json; // JSON
using System.Text.Json.Serialization;

public class Journal
{ 
    public List<Entry> _entries =  new List<Entry>();
        public void AddEntry (Entry info)  {

        _entries.Add(info);  
    }
    public void Display() 
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
}

    // Saving to a File
    public void SaveToFile() {

        Console.WriteLine("What is the filename?");

        string fileName = Console.ReadLine();

        List<Entry> data = new List<Entry>();
    
        foreach(Entry entry in _entries) {
            data.Add(entry);
        
        string jsonString = JsonSerializer.Serialize(data);
        File.WriteAllText(fileName, jsonString);           
    }

}
        
    public void LoadFromFile()

    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        string jsonString = File.ReadAllText(fileName);

        var entryList = JsonSerializer.Deserialize<List<Entry>>(jsonString);

        foreach(var entry2 in entryList) {
            _entries.Add(new Entry() {_date = entry2._date, _prompt = entry2._prompt, _response = entry2._response});
        }
  
    }

}
    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

