public class Purchase
{
    private List<Product> _listProducts = new List<Product>();
    private PaymentMethod _paymentMethod;
    private string _date;
    private float _amount;

    public Purchase(string date, List<Product> listProducts, PaymentMethod paymentMethod, float amount)
    {
        _date = date;
        _listProducts = listProducts;
        _paymentMethod = paymentMethod;
        _amount = amount;
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