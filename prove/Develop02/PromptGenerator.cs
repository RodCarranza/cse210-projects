using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> questions = new List <string>{
    "What was the most delicious food/dessert I ate today?",
    "What is one thing I learned today?",
    "What did I learn today from my personal scripture study?",
    "What was the weirdest thing about my day?",
    "If i had the chance to do something I was unable to do today, what would it be?",
    "How well did I do my job today?"};

    public Entry PromptQuestion() {

        Entry userInfo = new Entry();

        // Date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        userInfo._date = dateText;

        // Random question
        var random = new Random();
        var list = questions;
        int index = random.Next(list.Count);
        userInfo._prompt = list[index];
        Console.WriteLine(userInfo._prompt);

        // Response
        userInfo._response = Console.ReadLine();

        return userInfo;
    }
}

