using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("123 Apple St", "Salt Lake City", "UT", "USA");
        Customer cust1 = new Customer("John Smith", addr1);

        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "N123", 2.99, 5));
        order1.AddProduct(new Product("Pen Pack", "P456", 4.49, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        Address addr2 = new Address("456 Banana Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Alice Wong", addr2);

        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Binder", "B789", 6.99, 3));
        order2.AddProduct(new Product("Highlighters", "H101", 3.25, 4));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
