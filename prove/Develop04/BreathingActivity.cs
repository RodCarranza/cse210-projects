using System;

public class BreathingActivity: Activity

{

    public BreathingActivity(string activityName, string description) 
    : base (activityName, description)
    {

    }

    private void BreatheIn()
    {
        Console.Write("\nBreathe in...");
        PauseWhileCountdown(4);
    }

    private void BreatheOut()
    {
        Console.Write("Now breathe out...");
        PauseWhileCountdown(6);
    }

    public void Breathing()
    {
        // Set the time of the breathing activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDurationSec());

        while(DateTime.Now < endTime)
        {
            BreatheIn();
            Console.WriteLine();
            BreatheOut();
            Console.WriteLine();

        }
    }
}
