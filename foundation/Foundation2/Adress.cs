class Adress
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private bool _isInUSA;

    public Adress(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
        this._isInUSA = IsInUSA();
    }
    public string GetAdress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    public bool IsInUSA()
    {
        if (_country.ToLower() == "usa")
        {
            return true;
        }
        return false;
    }
}