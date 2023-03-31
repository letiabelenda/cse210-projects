public class DebitCard : PaymentMethod
{
    private float _discount;

    public double GetDiscount(double amount)
    {
        double _discount = amount * 0.95;
        return _discount;
    }
    
}