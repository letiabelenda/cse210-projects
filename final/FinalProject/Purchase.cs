public class Purchase
{
    private List<Product> _listProducts = new List<Product>();
    private PaymentMethod _paymentMethod;
    private string _date;
    private float _amount;
    public Purchase()
    {
        _amount = 0;
        DateTime timeOnly = new DateTime(DateTime.Now.TimeOfDay.Ticks);
        string dateText = timeOnly.ToString();
        
        _date = dateText;
    }

    public float CalculateTotalAmount()
    {
        float amount;

        foreach(Product product in _listProducts)
        {
            if(product.GetIsProductUnit())
            {
                ProductUnit productAux = (ProductUnit)product;
                amount = productAux.CalculateAmount();
            }
            else
            {
                ProductNoUnit productAux = (ProductNoUnit)product;
                amount = productAux.CalculateAmount();
            }
            _amount = _amount + amount;
        }
        return _amount;
        
    }
    public void FinishPurchase()
    {
        Console.Write("How do you like to pay: Cash(C) or Debit Card(D)?");
        string answer = Console.ReadLine();

        if(answer == "C")
        {
            Console.WriteLine("You don't receive any discount. Your final amount is the one already given.");
        }
        else
        {
            DebitCard debit = new DebitCard();
            double finalAmount = debit.GetDiscount(_amount);
            _amount = (float)finalAmount;
            Console.WriteLine($"You receive a 5% discount. The final amount is now {debit}");
        }
    }
    public void AddProduct(Product product)
    {
        _listProducts.Add(product);
    }
    //public void RemoveProduct(Product product)
    //{
        //_listProducts.Remove(product);
    //}
    public void SaveFile()
    {

        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_date}");

            foreach (Product product in _listProducts)
            {
                outputFile.WriteLine($"{product.GetName()}");
            }
            outputFile.WriteLine($"Total amount: {_amount}");
        }       
       
    }
    public void LoadFile(string fileName)
    {
        string[] purchase = System.IO.File.ReadAllLines(fileName);
        Console.WriteLine(purchase);
    }
    
}