using System;
class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Berkeley", "CA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        Product product1 = new Product("Widget", "W123", 19.99m, 2);
        Product product2 = new Product("Gadget", "G456", 29.99m, 1);
        Product product3 = new Product("Thingamajig", "T789", 9.99m, 5);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        Product product4 = new Product("Doohickey", "D012", 14.99m, 3);
        Product product5 = new Product("Whatchamacallit", "W345", 24.99m, 2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");
        Console.WriteLine();
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}