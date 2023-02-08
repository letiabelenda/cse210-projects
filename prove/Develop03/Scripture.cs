public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new List<Word>();

    public Scripture(string text){
        text = "Me gustan los michis";
         
        char [] separator = {' '};
        string[] strlist = text.Split(separator);

        foreach(string s in strlist)
        {
            Console.WriteLine(s);
        }
        Console.ReadKey();
    }
}