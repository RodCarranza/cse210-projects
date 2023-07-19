using System;

public class ListingActivity: Activity
{
    private List <string> _questionsList = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private List <string> _userInput = new List<string>();
    public ListingActivity(string activityName, string description) 
    : base (activityName, description)
    {

    }

    public void DisplayQuestion()
    {
        var random = new Random();
        var list = _questionsList;
        int index = random.Next(list.Count);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {list[index]} ---");
        Console.Write($"You may begin in: ");
        PauseWhileCountdown(5);
        Console.WriteLine();
    }

    public void SaveAnswers()
    {
        // Set the time of the listing activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDurationSec());
        string answer = "";
        
        while(DateTime.Now < endTime)
        {
            _userInput.Add(answer);
            answer = Console.ReadLine();
        } 
    }

    public void DisplayItemsTotal()
    {
        Console.WriteLine($"You listed {_userInput.Count} items!");
    }
}
