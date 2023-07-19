using System;

public class BreathingActivity: Activity

{

    public BreathingActivity(string activityName, string description) 
    : base (activityName, description)
    {

    }

    public void Breathing()
    {
        // Set the time of the breathing activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDurationSec());

        while(DateTime.Now < endTime)
        {
        Console.Write("\nBreathe in...");
        for(int i = 4; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(); 

        Console.Write("Now breathe out...");
        for(int i = 6; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
 
        }
        Console.WriteLine();

        } 

    }
 
    }
    


