using System;

class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double TotalCosts()
    {
        return _price * _quantity; 
    }

    public void ProducDisplay()
    {
        Console.WriteLine($"Product: {_name} --- ID: {_productId}");
    }
}