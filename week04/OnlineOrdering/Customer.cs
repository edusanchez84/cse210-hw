using System;

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LiveInUsa()
    {
        if (_address.IsInUsa() == true)
        return true;
        else
        return false;
    }

    public void CustomerName()
    {
        Console.WriteLine(_name);
    }

    public void CustomerAddress()
    {
        Console.WriteLine(_address.DisplayAddress());
    }
}