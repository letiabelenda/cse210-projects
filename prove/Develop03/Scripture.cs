public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new List<Word>();
    private int _length;
    private int _countHiddenWords;

    public Scripture(string book, string chapter, string firstVerse, string secondVerse, string rawText){

        char [] separator = {' '};
        string[] strlist = rawText.Split(separator);

        foreach(string str in strlist)
        {
            Word word = new Word(str);
            _text.Add(word);
        }
        
        _length = _text.Count;
        _countHiddenWords = 0;

        if (secondVerse == "")
        {
            _reference = new Reference(book, chapter, firstVerse); 
             
        } 
        else
        {
            _reference = new Reference(book, chapter, firstVerse, secondVerse);
        }            
    }

    public void HideWords(){
        int[] numbers = {};
        Random random = new Random();
        int i = 0;

        while (i < 3 && !IsCompletelyHidden())
        {
            int index = random.Next(_length);
            if (numbers.Contains(index)){
                _text[index].Hide();
                numbers.Append(index);
                i = i + 1;
                _countHiddenWords = _countHiddenWords + 1;
            }
        }
    }

    public List<Word> GetRenderedText(){
        return _text;
    }

    public Boolean IsCompletelyHidden(){

        if (_countHiddenWords == _length){
            return true;
        }
        else
        {
            return false;
        }
    }
}