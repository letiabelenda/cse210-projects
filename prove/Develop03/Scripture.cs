public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new List<Word>();

    public Scripture(string book, string chapter, string firstVerse, string secondVerse, string rawText){
         
        char [] separator = {' '};
        string[] strlist = rawText.Split(separator);

        foreach(string str in strlist)
        {
            Word word = new Word(str);
            _text.Add(word);
        }
        
        if (secondVerse == "")
        {
            Reference reference = new Reference(book, chapter, firstVerse);  
        } 
        else
        {
            Reference reference = new Reference(book, chapter, firstVerse, secondVerse);
        }            
    }

    public void HideWord(){
        
    }
}