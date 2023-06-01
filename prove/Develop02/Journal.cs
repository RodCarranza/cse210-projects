using System;
using System.IO; //File
using System.Collections.Generic;
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

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries) {
                outputFile.WriteLine($"{entry._date} - Prompt: {entry._prompt} - {entry._response}");
            }
        }

    }

    public void LoadFromFile() 

    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        //Opens the text file, reads all the lines and stores into a string array, and then closes the file.
        string [] lines = System.IO.File.ReadAllLines(fileName);

        
        // Iterates in the text file line by line.
        foreach(string line in lines)
        
        {
            string [] parts = line.Split("-");

            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            _entries.Add(new Entry() {_date = date, _prompt = prompt, _response = response});
  
        }
  
    }

}

    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

