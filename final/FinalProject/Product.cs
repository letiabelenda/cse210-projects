public abstract class Product
{
    protected string _name;
    protected float _price;
    protected ProductType _type;
    protected Boolean _isProductUnit;

    public Product(string name, float price, ProductType type)
    {
        _name = name;
        _price = price;
        _type = type;
    }
    public Product(string name, float price)
    {
        _name = name;
        _price = price;
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
    public Boolean GetIsProductUnit()
    {
        return _isProductUnit;
    }
    public abstract float CalculateAmount(float quantity);
}
