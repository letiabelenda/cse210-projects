public class Inventory
{
    private List<Product> _listProducts = new List<Product>();

    public void LoadProducts()
    {
        string[] products = System.IO.File.ReadAllLines("products.txt");

        foreach (string product in products)
        {
            string[] parts = product.Split(",");

            if(parts[3] == "unit")
            {
                ProductType productType = new ProductType(parts[4]);
                ProductUnit productUnit = new ProductUnit(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2]), productType);
                _listProducts.Add(productUnit);
            }
            else
            {
                ProductType productType = new ProductType(parts[4]);
                ProductNoUnit ProductNoUnit = new ProductNoUnit(parts[0], Int32.Parse(parts[1]), Int32.Parse(parts[2]), Int32.Parse(parts[3]), productType);
                _listProducts.Add(ProductNoUnit);
            }
        }
    }

    public void ListProducts()
    {       
        Console.WriteLine("The products are:");

        foreach (Product product in _listProducts)
        {
            if (product)
            Console.WriteLine($"{product.GetName} - {product.} - {product.GetPrice}");
        }

    }
    public void ChangePrice()
    {
        
    }
}