using System;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.InteropServices;

class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = [];
    }

    public void AddProduct(Product products)
    {
        _products.Add(products);
    }

    public int ShippingCost()
    {
        if (_customer.LiveInUsa() == true)
        return 5;
        else
        return 35;
    }

    public double OrderCost()
    {
        List<double> totalOrder = [];
        foreach (Product p in _products)
        {
            totalOrder.Add(p.TotalCosts());
        }
        return totalOrder.Sum() + ShippingCost();
    }

    public void PackingLabel()
    {
        foreach (Product l in _products)
        {
            l.ProducDisplay();
        }
    }

    public void ShippingLabel()
    {
        _customer.CustomerName();
        _customer.CustomerAddress();
    }
}