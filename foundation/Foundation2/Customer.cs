class Customer
{
    private string _name;
    private Adress _adress;

    public Customer(string name, Adress adress)
    {
        this._name = name;
        this._adress = adress;
    }

    public string DisplayText()
    {
        return $"Customer: {_name} - {_adress.GetAdress()}";
    }
    public bool IsInUSA()
    {
        if (_adress.IsInUSA() == true)
        {
            return true;
        }
        return false;
    }
}