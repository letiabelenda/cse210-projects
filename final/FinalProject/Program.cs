using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Mini Market!");
        Console.WriteLine("Remember to always write the name of the products with capital letter at the beginning of every word");
        int option;
        Inventory inventory = new Inventory();
        inventory.LoadProducts();

        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. List products available");
            Console.WriteLine("2. Sart a purchase");
            Console.WriteLine("3. Save purchase");
            Console.WriteLine("4. Load purchase");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");
            option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {
                inventory.ListProducts();
            }

            else if (option == 2)
            {
                Console.WriteLine();
            }

            else if (option == 3)
            {

            }

            else if (option == 4)
            {

            }
        } while (option != 5);
    }
}