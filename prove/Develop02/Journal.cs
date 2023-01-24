public class Journal{
    public List <Entry> _entries = new List<Entry>();

    public void AddingAnEntry(string _prompt, string _answer) {
        Entry entry = new Entry();

        DateTime today = DateTime.Today;
        entry._date = today.Day.ToString() + "/" + today.Month.ToString() + "/" + today.Year.ToString();
        
        entry._prompt = _prompt;

        entry._answer = _answer;      
    }

    
}
    