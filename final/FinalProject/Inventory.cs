public class Inventory
{
    private List<Product> _listProducts = new List<Product>();

    public void LoadProducts()
    {
        string[] products = System.IO.File.ReadAllLines("products.txt");

        foreach (string product in products)
        {
            string[] parts = product.Split(",");
            ProductType productType = new ProductType(parts[4]);

            if(parts[3] == "unit")
            {
                ProductUnit productUnit = new ProductUnit(parts[0], float.Parse(parts[1]), Int32.Parse(parts[2]), productType);
                _listProducts.Add(productUnit);
            }
            else
            {
                ProductNoUnit ProductNoUnit = new ProductNoUnit(parts[0], float.Parse(parts[1]), float.Parse(parts[2]), parts[3], productType);
                _listProducts.Add(ProductNoUnit);
            }
        }
    }

    public void ListProducts()
    {       
        Console.WriteLine("The products are:");

        foreach (Product product in _listProducts)
        {
            if (product.GetIsProductUnit())
            {
                Console.WriteLine($"{product.GetName()} - ${product.GetPrice()}");
            }
            else
            {
                ProductNoUnit productAux = (ProductNoUnit)product;
                Console.WriteLine($"{productAux.GetName()} - {productAux.GetQuantity()}{productAux.GetMeasure()} - ${productAux.GetPrice()}");
            }
        }

    }
    public void ChangePrice()
    {
        
    }
}