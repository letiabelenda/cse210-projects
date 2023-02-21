using System;

class Program
{
    static void Main(string[] args)
    {
        Reflecting prueba = new Reflecting("prueba", "lalalal", 20);
        prueba.DisplayRandomPrompt();
        prueba.GetRandomQuestion();
        prueba.GetRandomQuestion();
    }
}