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

            // 1. Write
            // Add inputs to the list
            myJournal.AddEntry(userInput.PromptQuestion());
            
        } else if (userChoice == "2") {

            // 2. Display
            // Display entries
            myJournal.Display();

        } else if (userChoice == "3") {

            // 3. Load
            // Call method to read from a file
            myJournal.LoadFromFile();


        } else if (userChoice == "4") {

            // Save to a file
            // Call method to save to a file
           myJournal.SaveToFile(myJournal._entries);


           
           //List<Entry> new_entries = myJournal.LoadFromFile();
        
           /*foreach (Entry e in new_entries) {

           Console.WriteLine(e._date);
            Console.WriteLine(e._prompt);
            Console.WriteLine(e._response);

           }*/

    }

    }
    }
}
        
