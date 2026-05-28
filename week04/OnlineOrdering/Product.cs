public class Product
{
    private string _name;
    private string _ID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string ID, decimal price, int quantity)
    {
        _name = name;
        _ID = ID;
        _price = price;
        _quantity = quantity;
    }

    public decimal GetTotalPrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _ID;
    }
}


