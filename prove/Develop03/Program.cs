using System;

class Program
{
    static void Main(string[] args)
    {

      /*A random scripture from a list is displayed every time the program is executed. 
       This what I did to exceed core requirements.*/

      List<Scripture> _scripturesList = new List<Scripture>();

      Reference reference1 = new Reference("Proverbs", 3, 5, 6);
      Reference reference2 = new Reference("Alma", 32, 21);
      Reference reference3 = new Reference("Mosiah", 2, 17);

     _scripturesList.Add(new Scripture(reference1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."));
     _scripturesList.Add(new Scripture(reference2,"And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true."));
     _scripturesList.Add(new Scripture(reference3,"And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God."));

     var random = new Random();
     var list = _scripturesList;
     int index = random.Next(list.Count);

     //--------------------------------------------
       _scripturesList[index].GetRenderedText();

       _scripturesList[index].ShuffleList();

       string response = " ";

        // The program can end in one of two ways: Either the user types quit, or all of the words in the scripture have been hidden.
        while(_scripturesList[index].IsCompletelyHidden()) {
        Console.WriteLine();
        Console.WriteLine("\nPress enter to continue or type quit to finish:");
        response = Console.ReadLine();
        
        if(response == "quit") {
            System.Environment.Exit(0);
        }
        else {
            Console.Clear();
            _scripturesList[index].HideWords();
            _scripturesList[index].GetRenderedText();
        }
       }
    }
}
