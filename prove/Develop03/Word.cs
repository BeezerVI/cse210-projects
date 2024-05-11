//Word class here (all the data that would be in a word
//Is this word hidden?
//diplay word
//Hide void
//Show void
//IsHidden bool
//GetDisplayText; string

//some vars would be the _word, and _isHidden (bool)

public class Word
{
    string _word;

    bool _isHidden;

    public Word(string word) //When class Word made start this code
    {
        _word = word;
        _isHidden = false;
    }

    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public string GetWordString(){
        return _word;
    }
    public bool IsHidden(){
        return _isHidden;
    }
}
