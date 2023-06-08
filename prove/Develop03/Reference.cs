using System;

public class Reference {

    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // Every member variable should be private. Getters and Setters should be used to access the data.
    // Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
    // Setters should accept a single parameter and have a void return type.

    /*
    Reference - Keeps track of the book, chapter, and verse information.
    ** At least 2 constructors in reference class
    */

    //Constructor for single verse
    public Reference(string book, int chapter, int verse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    //Constructor for multiple verses
    public Reference(string book, int chapter, int verse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetFormattedReference() {

        if(_endVerse > 0) {
            string reference = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return reference;

        }else {
            string reference = $"{_book} {_chapter}:{_verse}";
            return reference;
        } 
    }
    
}
