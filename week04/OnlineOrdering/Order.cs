public class Order
{
    private List<Product> _products;
    private Customer _customer;


    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (var product in _products)
        {
            total += product.CalculateTotal();
        }

        if (_customer.GetLocation() == "USA")
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    private string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in _products)
        {
            label += $"{product.GeneratePackingLabel()}\n";
        }
        return label;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine(GetPackingLabel());
    }


    private string GetShippingLabel()
    {
        return $"Shipping to: {_customer.GetLocation()}\n" +
               $"Address: {_customer.GetFullAddress()}";
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine(GetShippingLabel());
    }
}