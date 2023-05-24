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

    public void SaveToFile(Entry info2) {

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can use the $ and include variables just like with Console.WriteLine
            
            outputFile.WriteLine($"{info2}");
        }

    }


}

    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

