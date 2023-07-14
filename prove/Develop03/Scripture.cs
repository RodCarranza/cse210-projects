using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture 
{
    /*
    Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    */
    private string _reference;
    private string _scripture;
    private List<Word> _words = new List<Word>();
    private List<int> _integersList = new List<int>();
    private int _initialization = 0;
    private int _testCondition = 3;

    //Constructor that accepts the reference and text of the scripture
    public Scripture(Reference reference, string scripture) {
        _reference = reference.GetFormattedReference();
        _scripture = scripture;
        string[] arrayStrings = new string[]{_scripture};

        foreach(string word in arrayStrings) {
            //Splitting words by blank spaces
            string [] parts= word.Split(" ");

            for (int i = 0; i < parts.Length; i++) {
                _words.Add(new Word(parts[i]));
            }
        } 
    }

    public void ShuffleList() {
        //Suffle a list of integers that represents the words of the scripture.
        _integersList = Enumerable.Range(0, _words.Count).ToList();
        int lastIndex = _integersList.Count()-1;

        while (lastIndex > 0) {
            var tempValue = _integersList[lastIndex];
            int randomIndex = new Random().Next(0, lastIndex);
            _integersList[lastIndex] = _integersList[randomIndex];
            _integersList[randomIndex] = tempValue;

            lastIndex --;
        }
    }

    public void HideWords() {
    //In charge of hiding selected words randomly.
    for(int i = _initialization; i < _testCondition && i != _words.Count; i++)
    {
        _words[_integersList[i]].Hide();
    }
    // Increase the value to 3 each time the method is called.
    _initialization += 3;
    _testCondition += 3;

    }
    public bool IsCompletelyHidden() {

        if (_words.All(checkWords => checkWords.IsHidden())) {
                System.Environment.Exit(0);
        }
        return true;  
    }

    public void GetRenderedText() {
            Console.Write($"{_reference} ");
            foreach(var word in _words) {
                Console.Write(word.GetRenderedText());
            }

            } 
}
