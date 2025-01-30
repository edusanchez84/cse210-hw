using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("USA", "Florida", "Miami", "Santa Maria Street 325");
        Address address2 = new Address("CANADA", "Ontario", "Kenora", "Park Street 856");

        Customer customer1 = new Customer("Barak Obama", address1);
        Customer customer2 = new Customer("Richard Nikson", address2);

        Product product1 = new Product("PopSoda", 001, 2, 7);
        Product product2 = new Product("DrySoda", 002, 2.5, 15);
        Product product3 = new Product("SupSoda", 003, 3, 7);
        Product product4 = new Product("MegSoda", 004, 1, 10);
        Product product5 = new Product("TyreSoda", 005, 4.2, 3);
        Product product6 = new Product("FrizSoda", 006, 4.6, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        
        order1.PackingLabel();
        order1.ShippingLabel();
        Console.WriteLine($"The order total cost is: {order1.OrderCost()}");
        Console.WriteLine();
        Console.WriteLine();

        order2.PackingLabel();
        order2.ShippingLabel();
        Console.WriteLine($"The order total cost is: {order2.OrderCost()}");
        Console.WriteLine();
        Console.WriteLine();
    }
}