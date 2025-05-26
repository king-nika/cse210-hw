using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Example usage of the classes
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer = new Customer("John Doe", address);
        Product laptop = new Product("Laptop", "LAP123", 1000, 1);
        Product mouse = new Product("Mouse", "MOU456", 50, 2);
        Order order = new Order(customer);
        order.AddProduct(laptop);
        order.AddProduct(mouse);

        Console.WriteLine($"Hello {customer.GetName()}!");
        Console.WriteLine("Here are the details of your order:\n");
        order.DisplayPackingLabel();
        order.DisplayShippingLabel();
        Console.WriteLine($"Total Order Cost: ${order.CalculateTotal()}");
        Console.WriteLine("Thank you for using the OnlineOrdering system!");
    }
}