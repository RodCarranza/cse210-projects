using System;
public class Entry
{
    // Hold data and have a display method. 
    public string _date {get; set;}
    public string _prompt {get; set;}
    public string _response {get; set;}
    
public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_response}\n");
    }
}
