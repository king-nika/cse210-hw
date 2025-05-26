using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        // Example usage of the classes
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address);
        Product laptop = new Product("Laptop", "LAP123", 1000, 1);
        Product mouse = new Product("Mouse", "MOU456", 50, 2);
        Order order1 = new Order(customer1);
        order1.AddProduct(laptop);
        order1.AddProduct(mouse);

        Customer customer2 = new Customer("Jane Smith", new Address("456 Kim St", "Alabama", "Abuja", "Nigeria"));
        Product phone = new Product("Smartphone", "PHN789", 800, 1);
        Order order2 = new Order(customer2);
        order2.AddProduct(phone);
        order2.AddProduct(new Product("Charger", "CHR101", 20, 1));
        order2.AddProduct(new Product("Headphones", "HDP202", 100, 1));
        order2.AddProduct(new Product("Case", "CAS303", 30, 1));
        order2.AddProduct(new Product("Screen Protector", "SPT404", 15, 1));
        order2.AddProduct(new Product("USB Cable", "USB505", 10, 1));
        order2.AddProduct(new Product("Power Bank", "PB606", 50, 1));

        Console.WriteLine("Order One Details:");
        Console.WriteLine("=====================================");
        Console.WriteLine($"Hello {customer1.GetName()}!");
        Console.WriteLine("Here are the details of your order:\n");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotal()}");
        Console.WriteLine("Thank you for using the OnlineOrdering system!");

        Console.WriteLine("\nOrder Two Details:");
        Console.WriteLine("=====================================");
        Console.WriteLine($"Hello {customer2.GetName()}!");
        Console.WriteLine("Here are the details of your order:\n");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotal()}");
        Console.WriteLine("Thank you for using the OnlineOrdering system!");
    }
}