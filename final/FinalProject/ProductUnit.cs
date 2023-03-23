public class ProductUnit : Product
{
    private int _quantity;

    public ProductUnit(string name, float price, int quantity, ProductType type) : base(name, price, type)
    {
        _quantity = quantity;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
    public override float CalculateAmount(float quantity)
    {
        return quantity;
    }
}