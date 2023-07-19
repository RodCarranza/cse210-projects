using System;

public class ReflectingActivity: Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _promptQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",

    };

    public ReflectingActivity(string activityName, string description) 
    : base (activityName, description)
    {

    }

    private string GetRandomPrompt()
    {
        var random = new Random();
        var list = _prompts;
        int index = random.Next(list.Count);
        return $"--- {list[index]} ---\n";

    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("When you have something in mind, press enter to continue.");

        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in: ");
        PauseWhileCountdown(5);
    }

    private string GetRandomQuestion()
    {
        var random = new Random();
        var list = _promptQuestions;
        int index = random.Next(list.Count);
  
        return $"{list[index]} ";
    }

    public void DisplayPromptQuestion()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDurationSec());
        Console.Clear();

        while(DateTime.Now < endTime)
        {
            Console.Write(GetRandomQuestion());
            PauseWhileSpinner(15);
        }

    }

}
