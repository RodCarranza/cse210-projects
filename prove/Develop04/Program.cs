using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while(choice != "4") 
        {

            Console.Clear();

            // Menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if(choice == "1") {
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity("Breathing",
                "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.DisplayStartingMsg();
                breathing.PauseWhileSpinner(5);
                breathing.Breathing();
                breathing.DisplayEndingMsg();
                

            } else if (choice == "2") {
                Console.Clear();
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting",
                "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."); 
                reflecting.DisplayStartingMsg();
                reflecting.PauseWhileSpinner(5);
                reflecting.DisplayPrompt();
                reflecting.DisplayPromptQuestion();
                reflecting.DisplayEndingMsg();


            } else if (choice == "3") {

                Console.Clear();
                ListingActivity listing = new ListingActivity("Listing",
                "reflect on the good things in your life by having you list as many things as you can in a certain area."); 
                listing.DisplayStartingMsg();
                listing.PauseWhileSpinner(5);
                listing.DisplayQuestion();
                listing.SaveAnswers();
                listing.DisplayItemsTotal();
                listing.DisplayEndingMsg();
            } 

        }  
    }

}
