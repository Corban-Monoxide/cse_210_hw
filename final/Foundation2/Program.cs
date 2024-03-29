// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         // Console.WriteLine("Hello Foundation2 World!");
//         Address address = new Address();
//         Customer customer = new Customer("Adam", address);

//     }
// }
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Elm St", "Othercity", "NY", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product product1 = new Product("Widget", "W001", 10, 2);
        Product product2 = new Product("Gadget", "G002", 15, 3);
        Product product3 = new Product("Thingamajig", "T003", 5, 4);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GeneratePackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GenerateShippingLabel());
        Console.WriteLine("\nOrder 1 Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine("\nOrder 2 Packing Label:");
        Console.WriteLine(order2.GeneratePackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GenerateShippingLabel());
        Console.WriteLine("\nOrder 2 Total Cost: $" + order2.CalculateTotalCost());
    }
}
