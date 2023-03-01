using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 3);
        string color = square.GetColor();
        double area = square.GetArea();

        Console.WriteLine($"This square is {color} and its area is {area}");

    }
}