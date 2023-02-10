using System;

class Program
{
    static void Main(string[] args)
    {   
        //Crear lista de Scriptures, y de forma randomica elegir una de ellas
        Scripture scripture1 = new Scripture("DyC", "121", "7", "", "My son, apeace be unto thy soul; thine badversity and thine afflictions shall be but a csmall moment;");
        
        while (!scripture1.IsCompletelyHidden()) //|| "no quit")
        {
            scripture1.PrintScripture();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");

            Console.ReadLine();
            
            Console.Clear();

            scripture1.HideWords();

        }
    }
}