using System;

public class Reference {
    /*
    Reference - Keeps track of the book, chapter, and verse information.
    */
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

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
