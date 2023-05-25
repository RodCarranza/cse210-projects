using System;

class Program
{
    static void Main(string[] args)
    {
        string userChoice = "";

        //Objects
        PromptGenerator userInput = new PromptGenerator();
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
               // Call method and add inputs to the list
               myJournal.AddEntry(userInput.PromptQuestion());
            
        } else if (userChoice == "2") {
            // Display entries
            myJournal.Display();

        } else if (userChoice == "3") {

            // Call method to read from a file
            //myJournal.ReadFromFile();


        } else if (userChoice == "4") {
            // Call method to save to a file
            myJournal.SaveToFile(myJournal._entries);

        }
    }

    }
}
