using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("1 Nephi", "2", "4", "5", "Me gustan los michis");
        Word word = new Word("");
        Console.WriteLine(scripture);
    }
}