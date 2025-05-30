using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (customer in the USA)
        Address address1 = new Address("123 Elm Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A001", 1200, 1));
        order1.AddProduct(new Product("Mouse", "B002", 25, 2));

        // Second order (international customer)
        Address address2 = new Address("456 Maple Avenue", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Carlos Ruiz", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "C003", 300, 1));
        order2.AddProduct(new Product("Stylus Pen", "D004", 40, 3));

        // Display orders
        DisplayOrder(order1);
        Console.WriteLine("---------------------------");
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.GetTotalPrice():0.00}");
    }
}
