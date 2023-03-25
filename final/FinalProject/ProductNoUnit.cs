public class ProductNoUnit : Product
{
    private float _quantity;
    private float _measure;

    public ProductNoUnit(string name, float price, float quantity, float _measure ProductType type): base(name, price, type)
    {

    }

    public float GetQuantity()
    {
        return _quantity;
    }
    public float GetMeasure()
    {
        return _measure;
    }
    public override float CalculateAmount(float userQuantity)
    {
        return (userQuantity * price) / _quantity;
    }
}