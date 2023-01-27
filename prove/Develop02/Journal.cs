public class Journal{
    public List <Entry> _entries = new List<Entry>();

    public void AddingAnEntry(string prompt, string answer) {
        Entry entry = new Entry();

        DateTime today = DateTime.Now;
        string dateText = today.ToShortDateString();

        entry._date = dateText;
        entry._prompt = prompt;
        entry._answer = answer;   

        _entries.Add(entry);

    }

    public void DisplayAllTheEntries() {
        foreach(Entry entry in _entries)
        {   
            string date = entry._date;
            string prompt = entry._prompt;
            string answer =  entry._answer;

            Console.WriteLine($" \n Date: {date} - Prompt: {prompt} \n {answer}");
        }
    }

    public void SavingToAFile(string fileName) {

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(Entry entry in _entries) 
            {   
                string date = entry._date;
                string prompt = entry._prompt;
                string answer = entry._answer;

                outputFile.WriteLine($"{date} - {prompt} \n {answer}");            
            }
            

        }
    }

    public void LoadingFromAFile(string fileName) {

        string[] lines = System.IO.File.ReadAllLines(fileName);

        int i = 1;
        string date = "";
        string prompt = "";

        foreach (string line in lines)
        {   
            if (i%2 != 0)
            {
            string[] parts = line.Split(" - ");

            date = parts[0];
            prompt = parts[1];
            }
            else {
                Entry entry = new Entry();

                entry._date = date;
                entry._prompt = prompt;
                entry._answer = line;

                _entries.Add(entry);
            }
            i = i + 1;
            
        }

        
        
    }

    
}
    