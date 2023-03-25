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

    }
    public void LoadFile()
    {
        
    }
    
}