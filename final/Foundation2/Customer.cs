public class Customer
{
    private string _name;
    private int _type;
    private Address address;

    public Customer(int type)
    {
        _type = type;
        address = new Address(_type);
        if (type == 1){
            _name = "Hyrum McKay";
        }
        else if (type == 2){
            _name = "Princesses";
        }
        else {_name = "Unicorn";}
    }

    public bool IsInTheUS()
    {
        return address.IsInTheUS();
    }

    public Address ReturnAddress()
    {
        return address;
    }

    public string GetShippingLabelString()
    {
        return $"{_name}, {address.GetAddressString()}";
    }
}
