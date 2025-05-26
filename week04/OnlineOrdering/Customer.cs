public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetLocation()
    {
        return _address.IsInUSA() ? "USA" : "International";
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetName()
    {
        return _name;
    }
}