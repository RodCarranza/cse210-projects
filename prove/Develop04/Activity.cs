using System;

public class Activity 

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

    public void DisplayStartingMsg() {
        Console.WriteLine($"Welcome to the {_activityName} Activity.\n"); //Activity name
        Console.WriteLine($"This activity will help you {_description}\n"); //Description
        Console.Write($"How long, in seconds, would you like for your session? "); //Duration
        _durationSec = Int32.Parse(Console.ReadLine());
                
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void PauseWhileSpinner() {

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
        DateTime endTime = startTime.AddSeconds(5);

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

    public void PauseWhileCountdown() {
        for(int i = 5; i > 0; i--) 
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }

    public void DisplayEndingMsg() {
        /*
         Well done!!
         You have completed another X seconds of the X activity.
        */

        Console.WriteLine("\nWell done!!");
        PauseWhileSpinner();
        Console.WriteLine($"\nYou have completed another {_durationSec} seconds of the {_activityName} Activity.");
        PauseWhileSpinner();
        
    }

}
