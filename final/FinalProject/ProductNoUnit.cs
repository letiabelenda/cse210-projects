public class ProductNoUnit : Product
{
    private float _quantity;
    private string _measure;

    public ProductNoUnit(string name, float price, float quantity, string measure, ProductType type): base(name, price, type)
    {
        _quantity = quantity;
        _measure = measure;
        _isProductUnit = false;
    }

    public float GetQuantity()
    {
        return _quantity;
    }
    public string GetMeasure()
    {
        return _measure;
    }
    public override float CalculateAmount()
    {
        return (_userQuantity * _price) / _quantity;
    }
}