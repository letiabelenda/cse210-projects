using System;

class Program
{
    static void Main(string[] args)
    {   
        //Crear lista de Scriptures, y de forma randomica elegir una de ellas
        Scripture scripture = new Scripture("1 Nephi", "2", "4", "5", "Me gustan los michis");
        
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