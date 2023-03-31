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
            Console.WriteLine("3. Load purchase");
            Console.WriteLine("4. Exit");
            Console.Write("Please choose an option: ");
            option = Int32.Parse(Console.ReadLine());

            if (option == 1)
            {
                inventory.ListProducts();
            }

            else if (option == 2)
            {
                Purchase purchase = new Purchase();
                string finish;

                do
                {
                    Console.Write("What product do you want to buy (type de number)? ");
                    int numProduct = Int32.Parse(Console.ReadLine());
                    Console.Write("How much do you want to buy? ");
                    float userQuantity = float.Parse(Console.ReadLine());

                    Product product = inventory.GetProduct(numProduct);
                    if(product.GetIsProductUnit())
                    {
                        ProductUnit productAux = (ProductUnit)product;
                        ProductUnit productUnit = new ProductUnit(product.GetName(), product.GetPrice(), productAux.GetQuantity(), product.GetProductType());
                        productUnit.SetUserQuantity(userQuantity);
                        purchase.AddProduct(productUnit);
                    }
                    else
                    {
                        ProductNoUnit productAux = (ProductNoUnit)product;
                        ProductNoUnit productNoUnit = new ProductNoUnit(product.GetName(), product.GetPrice(), productAux.GetQuantity(), productAux.GetMeasure(), product.GetProductType());
                        productNoUnit.SetUserQuantity(userQuantity);
                        purchase.AddProduct(productNoUnit);
                    }
                    Console.Write("Do you like to add another product (Y or N)? ");
                    finish = Console.ReadLine();

                }while(finish == "Y");
                
                float totalAmount = purchase.CalculateTotalAmount();

                Console.WriteLine($"The total amount to pay is {totalAmount}");
                purchase.FinishPurchase();
                Console.Write("Do you want to save this purchase (Y or N) ?");
                string answerSave = Console.ReadLine();

                if(answerSave == "Y")
                {
                    purchase.SaveFile();
                }       
            
                else
                {
                    Console.WriteLine("Thank you and good bye!");
                }


            }
            else if (option == 3)
            {
                Console.Write("What is the filename for the goal file? ");
                string fileName = Console.ReadLine();

                Purchase purchase = new Purchase();
                purchase.LoadFile(fileName);
            }
        } while (option != 4);
    }
}