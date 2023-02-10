public class Reference{
    private string _book;
    private string _chapter;
    private string _firstVerse;
    private string _secondVerse;

    public Reference(string book, string chapter, string firstVerse) {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = "";
    }
    public Reference(string book, string chapter, string firstVerse, string secondVerse) {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _secondVerse = secondVerse;
    }
    
    public string GetBook(){
        return _book;
    }
     public string GetChapter(){
        return _chapter;
    }
     public string GetFirstVerse(){
        return _firstVerse;
    }
     public string GetSecondVerse(){
        return _secondVerse;
    }
    public void PrintReference(){
        if (_secondVerse == ""){
            Console.Write(_book + " " + _chapter + ":" + _firstVerse + " ");
        }
        else
        {
            Console.Write(_book + " " + _chapter + ":" + _firstVerse + "-" + _secondVerse + " ");
        }        
    }
}