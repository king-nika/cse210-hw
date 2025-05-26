public class Product
{
    private string _name;
    private string productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        this.productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateTotal()
    {
        return _price * _quantity;
    }

    public string GeneratePackingLabel()
    {
        return $"Name: {_name} - Product ID: {productId}";
    }
}