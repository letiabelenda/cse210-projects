public class ProductNoUnit : Product
{
    private float _quantity;

    public ProductNoUnit(string name, float price, float quantity, ProductType type): base(name, price, type)
    {

    }

    public float GetQuantity()
    {
        return _quantity;
    }
    public override float CalculateAmount(float quantity)
    {
        return quantity;
    }
}