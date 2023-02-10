using System;

class Program
{
    static void Main(string[] args)
    {   
        //Crear lista de Scriptures, y de forma randomica elegir una de ellas
        List<Scripture> scriptures = new List<Scripture>();
        
        Scripture scripture1 = new Scripture("DyC", "121", "7", "", "My son, peace be unto thy soul; thine adversity and thine afflictions shall be but a small moment;");
        Scripture scripture2 = new Scripture("Proverbs", "3", "5", "6", "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways aacknowledge him, and he shall direct thy paths.");
        Scripture scripture3 = new Scripture("1 Nephi", "3", "7", "", "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        
        Random random = new Random();
        int index = random.Next(0, 3);
        Scripture scripture = (scriptures[index]);

        while (!scripture.IsCompletelyHidden()) //|| "no quit")
        {
            scripture.PrintScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            Console.ReadLine();
            
            Console.Clear();

            scripture.HideWords();

        }
    }
}