public class Order
{
    private int _type;
    private Customer _customer;
    private List<Product> _items = new List<Product>();

    public Order(int type)
    {
        _type = type;
        _customer = new Customer(_type); // Initialize _customer before using it
        AddProductList(type);

        Console.WriteLine("\nReceipt:");
        DisplayPackingLabel();
        Console.WriteLine("\nGoing to:");
        GetShipingLabelString();
    }

    public void AddProductList(int type)
    {
        if (type == 1)
        {
            _items.Add(new Product("Cheese", 123, 5));
            _items.Add(new Product("Milk", 124, 4));
            _items.Add(new Product("Apple", 5, 1));
            _items.Add(new Product("Another Apple", 5, 1));
        }
        else if (type == 2)
        {
            _items.Add(new Product("Controller", 101, 30));
            _items.Add(new Product("Gaming VR quest3", 345, 500));
            _items.Add(new Product("Monitor", 276, 32));
            _items.Add(new Product("Head Phones", 193, 60));
        }
        else
        {
            _items.Add(new Product("Oat meal", 2305, 10));
            _items.Add(new Product("Milk", 124, 4));
            _items.Add(new Product("Apple", 5, 1));
        }
    }

    public double CalculateTotal()
    {
        double totalPrice = 0;
        foreach (Product product in _items)
        {
            totalPrice += product.GetProductPrice();
        }
        if (_customer.IsInTheUS())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _items)
        {
            Console.WriteLine(product.GetProductDetails());
        }
        Console.WriteLine($"Total price is ${CalculateTotal()}");
    }

    public void GetShipingLabelString()
    {
        Console.WriteLine(_customer.GetShippingLabelString());
    }
}
