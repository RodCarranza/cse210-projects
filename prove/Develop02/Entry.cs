using System;
using System.Collections.Generic;
public class Entry
{
    //Hold data
    public string _prompt;
    public string _response;
    public string _date;
    


    public void Display()
    {
        //Console.WriteLine($"{_date} - Prompt: ({_prompt})");
        //Console.WriteLine($"{_response}");
        Console.WriteLine($"Prompt: ({_prompt})");
        Console.WriteLine($"{_response}");

    }
}
