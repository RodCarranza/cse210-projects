using System;
using System.Collections.Generic;

public class Scripture {
    
    // Every member variable should be private. Getters and Setters should be used to access the data.
    // Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
    // Setters should accept a single parameter and have a void return type.

    /*
    Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    */

    private string _reference;
    private string _scripture;

    //Constructor that accepts the reference and text of the scripture

    public Scripture(Reference reference, string scripture) {
        _reference = reference.GetFormattedReference();
        _scripture = scripture;
        string[] arrayStrings = new string[]{_scripture};

        //List of Word objects
        List<Word> words = new List<Word>();

        foreach(string word in arrayStrings) {
            //splitting words by blank spaces
            string [] parts= word.Split(" ");

            for (int i = 0; i < parts.Length; i++) {
                words.Add(new Word(parts[i]));
            }

        }
        
    }

    public void HideWords() {
        Console.Write(_reference);
        Console.Write($" {_scripture}");
        Console.ReadLine();

        Console.Clear();

        }

    public void IsCompletelyHidden() {

        }

    public string GetRenderedText() {
        string fullScripture = $"{_reference} {_scripture}";
        return fullScripture;
    }
    

}

