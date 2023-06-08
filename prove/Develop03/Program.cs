using System;

class Program
{
    static void Main(string[] args)
    {
        // The program can end in one of two ways: Either the user types quit, or all of the words in the scripture have been hidden.

        Reference reference = new Reference("Juan", 1, 15);
        
        Scripture scripture = new Scripture(reference, "Esta es la escritura que debe aparecer en el programa.");

        Console.WriteLine(scripture.GetRenderedText());

    }
}
