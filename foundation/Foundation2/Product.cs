class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;
    private decimal _Cost = 0;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
        this._Cost = price * quantity;
    }
    public string DisplayText()
    {
        return $"{_name} - ID: {_productId} - Price: {_price} - Quantity: {_quantity} - Cost: {_Cost}";
    }
    public decimal GetCost()
    {
        return _Cost;
    }
}