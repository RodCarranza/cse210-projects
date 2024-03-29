using System;

public class Activity //Base class

{
    private string _activityName;
    private string _description;
    private int _durationSec;

    public Activity(string activityName, string description) 
    {
        _activityName = activityName;
        _description = description;
        _durationSec = 0;
    }

    public int GetDurationSec()
    {
        return _durationSec;
    }

    public void DisplayStartingMsg() 
    {
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n"); //Activity name
        Console.WriteLine($"This activity will help you {_description}\n"); //Description
        Console.Write($"How long, in seconds, would you like for your session? "); //Duration
        _durationSec = Int32.Parse(Console.ReadLine());
                
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void PauseWhileSpinner(int seconds) {

        //Animation
        List<string> spinnerAnimation = new List<string>();
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("\\");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("/");
        spinnerAnimation.Add("-");
        spinnerAnimation.Add("|");
        spinnerAnimation.Add("\\");

        //Period of time for the animation
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while(DateTime.Now < endTime) 
        {
            string s = spinnerAnimation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            //When reaching the end of the list, set i to 0 again. 
            if (i >= spinnerAnimation.Count) 
            {
                i = 0;
           }
        }

        Console.WriteLine();
    }

    public void PauseWhileCountdown(int countdown) {
        for(int i = countdown; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void DisplayEndingMsg() {

        Console.WriteLine("\nWell done!!");
        PauseWhileSpinner(5);
        Console.WriteLine($"You have completed another {_durationSec} seconds of the {_activityName} Activity.");
        PauseWhileSpinner(5);
        
    }

}
