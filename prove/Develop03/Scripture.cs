using System;

public class Scripture {
    
    // Every member variable should be private. Getters and Setters should be used to access the data.
    // Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
    // Setters should accept a single parameter and have a void return type.

    /*
    Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    */

    private string _reference;
    private string _scripture;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string scripture) {
        _reference = reference.GetFormattedReference();
        _scripture = scripture;
    }

    public string GetRenderedText() {
        string fullScripture = $"{_reference} {_scripture}";
        return fullScripture;
    }
        
}


