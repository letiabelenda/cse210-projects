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
                ProductUnit productUnit = new ProductUnit(parts[0], parts[1], parts[2], parts[4])
                _listProducts.Add(productUnit);
            }
            else
            {
                ProductNoUnit ProductNoUnit = new ProductNoUnit(parts[0], parts[1], parts[2], parts[3], parts[4])
                _listProducts.Add(ProductNoUnit);
            }
        }
    }

    public void ListProducts()
    {       
        int index = 0;
        Console.WriteLine("The products are:")

        foreach (Product product in _listProducts)
        {

        }

    }
    public void ChangePrice()
    {
        
    }
}