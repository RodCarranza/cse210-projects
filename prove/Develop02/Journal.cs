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
       List<Entry> new_entries = LoadFromFile();
        
        
       foreach (Entry e in new_entries) {

        Console.WriteLine(e._date);
            //Console.WriteLine(e._prompt);
            //Console.WriteLine(e._response);
       }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }//return and receive value to the program class.

}
    

    // Saving to a File
    public void SaveToFile(List<Entry> _entries) {

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

    public List<Entry> LoadFromFile() 
    {
        List<Entry> _entries = new List<Entry>();
        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach(string line in lines) 
        {

            string [] parts = line.Split(",");

            Entry new_entries = new Entry();

            new_entries._date = parts[0];
            // Not sure why it should be one thing here.
            // If I put another one, the data in the file gets duplicate. 

            _entries.Add(new_entries);



        }

        return _entries;
    }
}




    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

