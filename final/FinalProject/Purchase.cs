public class Purchase
{
    private List<Product> _listProducts = new List<Product>();
    private PaymentMethod _paymentMethod;
    private string _date;
    private float _amount;
    public Purchase()
    {

    }
    public void SetDate()
    {
        DateTime timeOnly = new DateTime(DateTime.Now.TimeOfDay.Ticks);
        string dateText = timeOnly.ToString();
        
        _date = dateText;
    }
    public void SetAmount()
    {
        
    }
    public void FinishPurchase()
    {
        Console.Write("How do you like to pay: Cash(C) or Debit Card(D)?");
        string answer = Console.ReadLine();

        if(answer == "C")
        {
            Console.WriteLine($"The final amount is");
        }
        else
        {
            Console.WriteLine($"The final amount is");
        }
    }
    public void AddProduct(Product product)
    {
        _listProducts.Add(product);
    }
    public void RemoveProduct(Product product)
    {
        _listProducts.Remove(product);
    }
    public void SaveFile(string fileName)
    {
       using (StreamWriter outputFile = new StreamWriter(fileName))
       {
            foreach (Product product in _listProducts)
            {
                
            }
       }       
    }
    public void LoadFile(string fileName)
    {
        
    }
    
}