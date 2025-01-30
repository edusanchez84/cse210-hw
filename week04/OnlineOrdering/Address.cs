using System;

class Address
{
    private string _country;
    private string _state;
    private string _city;
    private string _streetAddress;

    public Address(string country, string state, string city, string address)
    {
        _country = country;
        _state = state;
        _city = city;
        _streetAddress = address;
    }

    public bool IsInUsa()
    {
        if (_country == "USA")
        return true;
        else
        return false;
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_city} \n{_state} {_country}";
    }
}