public abstract class Product
{
    protected string _name;
    protected float _price;
    protected ProductType _type;

    public Product(string name, float price, ProductType type)
    {
        _name = name;
        _price = price;
        _type = type;
    }

    public string GetName()
    {
        return _name;
    }
    public float GetPrice()
    {
        return _price;
    }
    public ProductType GetProductType()
    {
        return _type;
    }
    public abstract float CalculateAmount(float quantity);
}
