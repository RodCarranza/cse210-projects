using System;


public class Entry
{
    // Hold data and have a display method. 
    public string _prompt;
    public string _response;
    public string _date;
    

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
        Console.WriteLine($"{_response}");

    }
}
