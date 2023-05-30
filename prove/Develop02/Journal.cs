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
                outputFile.WriteLine($"{entry._date} Prompt: {entry._prompt}");
                outputFile.WriteLine($"{entry._response}\n");

            }
        }

    }

    public void LoadFromFile() 
    {
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        //Opens the text file, reads all the lines and stores into a string array, and then closes the file.
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        // Iterates in the text file line by line.
        foreach(string line in lines) 
        {
            //Creates another array, but this one splits the strings into substrings 
            string [] parts = line.Split("|"); //Delimiter is "|"

            string date = parts[0];

            Entry new_entries = new Entry ();
            new_entries._date = parts[0];
            new_entries._prompt = parts[0];
            new_entries._response = parts[0];
            _entries.Add(new_entries); 

        }

        
    }


}

    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

