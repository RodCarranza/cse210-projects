using System;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {
        
        string userChoice = "";

        //Object of class PromptGenerator and Entry
        
        Entry userResponse = new Entry();
        PromptGenerator listofQuestions = new PromptGenerator();

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
            listofQuestions.RandomQuestions();
            userResponse._response = Console.ReadLine();
            

            

        } else if (userChoice == "2") {
            userResponse.Display();
        }




        }


        
        
    }
}
