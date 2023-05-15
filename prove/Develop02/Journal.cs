using System;
using System.Collections.Generic;
public class PromptGenerator

{
    public void RandomQuestions()
    {

    Entry entry1 = new Entry();
    entry1._prompt = "What was the most delicious food/dessert I ate today?";

    Entry entry2 = new Entry();
    entry2._prompt = "What is one thing I learned today?";

    Entry entry3 = new Entry();
    entry3._prompt = "What did I learn today from my personal scripture study?";

    Entry entry4 = new Entry();
    entry4._prompt = "What was the weirdest thing about my day?";

    Entry entry5 = new Entry();
    entry5._prompt = "If i had the chance to do something I was unable to do today, what would it be?";

    Entry entry6 = new Entry();
    entry6._prompt = "How well did I do my job today?";



    //Journal

    Journal myJournal = new Journal();
    
    myJournal._entries.Add(entry1);
    myJournal._entries.Add(entry2);
    myJournal._entries.Add(entry3);
    myJournal._entries.Add(entry4);
    myJournal._entries.Add(entry5);
    myJournal._entries.Add(entry6);

    var random = new Random();
    int index = random.Next(myJournal._entries.Count);
    Console.WriteLine(myJournal._entries[index]);

    }

    }
