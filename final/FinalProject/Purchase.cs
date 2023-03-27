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

    public void AddProduct()
    {
        
    }
    public void RemoveProduct()
    {

    }
    public void FinishPurchase()
    {

    }
    public void SaveFile()
    {
       Console.Write("What is the filename for the goal file? ");
       string fileName = Console.ReadLine();

       using (StreamWriter outputFile = new StreamWriter(fileName))
       {
            foreach (Product product in _listProducts)
            {

            }
       }       
    }
    public void LoadFile()
    {
        
    }
    
}