using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.\n");
        
        //---------------------------------------------

       scripture.GetRenderedText();

       scripture.ShuffleList();

       string response = " ";

        // The program can end in one of two ways: Either the user types quit, or all of the words in the scripture have been hidden.

        while(scripture.IsCompletelyHidden()) {

        Console.WriteLine("\nPress enter to continue or type quit to finish:");
        response = Console.ReadLine();
        
        if(response == "quit") {
            System.Environment.Exit(0);
        }
        else {
            Console.Clear();
            scripture.HideWords();
            scripture.GetRenderedText();
        }
       
       }
    }
}

