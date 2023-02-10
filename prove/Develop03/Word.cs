public class Word{
    private string _word;
    private Boolean _hidden;

    public Word(string word){
        _word = word;
        _hidden = false;
    }

    public void Hide(){
        _hidden = true;
    }

    public string GetRenderedWord(){
        if (_hidden){
            return "___";
        }
        else
        {
            return _word;
        }
    }   
}
