using System;

class Program
{

    static void Main(string[] args)
    {
        
        string userChoice = "";

        //Objects
        
        Entry userInfo = new Entry();
        PromptGenerator promptQuestion = new PromptGenerator();
        Journal myJournal = new Journal();
        

        Console.WriteLine("Welcome to the Journal Program!");

        while(userChoice != "5") 
        {
        Console.WriteLine("\nPlease select one of the following choices:");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("What would you like to do? ");
        userChoice = Console.ReadLine();

            if(userChoice == "1") {

                //Date
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                userInfo._date = dateText;


                //Prompt random question
                
                var random = new Random();
                var list = promptQuestion.questions;
                int index = random.Next(list.Count);
                userInfo._prompt = list[index];
                Console.WriteLine(userInfo._prompt);

                //Response
                userInfo._response = Console.ReadLine();
            

        } else if (userChoice == "2") {
            myJournal._entries.Add(userInfo);
            myJournal.Display();
            
        }

        }
       
        
    }
}
