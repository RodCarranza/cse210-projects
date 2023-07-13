using System;

public class Word {
    /*
    Keeps track of single words and initialize their state (hidden or shown).
    */
    private string _words;
    private bool _isHidden;

    public Word(string words) {
        _words = words;
        _isHidden = false;
    }
    //Methods
    public void Hide() {
        _isHidden = true;  
    }
    public bool IsHidden() {
        return _isHidden; 

    }
    public string GetRenderedText() {
        if(_isHidden) {
            string hiddenWords = new String('_', _words.Length);
            return hiddenWords + " ";

        } else {
            return _words + " "; 

        }
    }
}
