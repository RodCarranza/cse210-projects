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

    /*public void ReadFromFile()
    {
        string fileName = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
    {
            string[] parts = line.Split(",");

            string userDate = parts[0];
            string userPrompt = parts[1];
            string userResponse = parts[1];                  
    }   */


    }



    // Adding an entry
    // Displaying all the entries
    // The Journal display method could iterate through all Entry objects and call the Entry display method
    // Saving to a file *
    // Loading from a file *

