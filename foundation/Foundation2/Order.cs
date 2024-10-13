class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }
    public void CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetCost();
        }
        if (_customer.IsInUSA() == true)
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        Console.WriteLine($"Total cost: {totalCost}");
    }
    public void ShippingLabel()
    {
        Console.WriteLine(_customer.DisplayText());
        foreach (Product product in _products)
        {
            Console.WriteLine(product.DisplayText());
        }
        CalculateTotalCost();
    }
}