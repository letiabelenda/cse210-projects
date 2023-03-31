public class DebitCard : PaymentMethod
{
    private float _discount;

    public DebitCard()
    {
        
    }
    public float GetDiscount(float amount)
    {
        _discount = (float)(amount * 0.95);
        return _discount;
    }
    
}