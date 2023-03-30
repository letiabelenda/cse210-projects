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
            Console.WriteLine("2. Start a purchase");
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
                Console.Write("What product do you want to buy (type de number)?");
                int name = Int32.Parse(Console.ReadLine());
                Console.Write("How much do you want to buy?");
                float quantity = float.Parse(Console.ReadLine());

                Product product = new Product();
                inventory.AddProduct(product);
                
            }

            else if (option == 3)
            {
                Console.Write("What is the name of the file? ");
                string fileName = Console.ReadLine();
                Purchase purchase = new Purchase();
                purchase.SaveFile(fileName);
            }

            else if (option == 4)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                Purchase purchase = new Purchase();
                purchase.LoadFile(fileName);
            }
        } while (option != 5);
    }
}