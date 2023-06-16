using System;

public class Word {

    private string _words;

    // Every member variable should be private. Getters and Setters should be used to access the data.
    // Getters should not have any parameters and should not prompt the user for anything, but instead, simply return a value.
    // Setters should accept a single parameter and have a void return type.

    /*
    Word - Keeps track of a single word and whether it is shown or hidden. 
    which has the responsibility for storing the text of a word and whether it is hidden or not,
    */

    //Constructor

    /* 
     In addition, the constructor will need to set the initial visibility of the word 
    (whether it is shown or hidden). Is this something that the user should pass in directly, or can the constructor just assign a value?

    */

    public Word(string words) {
        _words = words;   

    }

    //Methods

    public void Hide() {

    }

    public void Show() {

    }

    public void IsHidden() {

    }

    public void GetRenderedText() {
        //Could be string instead of void
    }

}

