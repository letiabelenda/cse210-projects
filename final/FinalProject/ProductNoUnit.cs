public class ProductNoUnit : Product
{
    private float _quantity;
    private float _measure;

    public ProductNoUnit(string name, float price, float quantity, float measure, ProductType type): base(name, price, type)
    {
        _quantity = quantity;
        _measure = measure;
        _isProductUnit = false;
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
        return (userQuantity * _price) / _quantity;
    }
}