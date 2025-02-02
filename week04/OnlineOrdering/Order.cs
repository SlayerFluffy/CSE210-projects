public class Order
{
    //Attributes:
    private Customer _customer;
    private List<Product> _products;
    private Address _address;
    
    //Constructor:
    public Order(Customer customer, Address address)
    {
        _customer = customer;
        _address = address;
        List<Product> products = new List<Product>();
        _products = products;
    }
    
    //Methods:
    public void Add_Product(string name, int productID, double price, double quantity)
    {
        Product newProduct = new Product(name, productID, price, quantity);
        _products.Add(newProduct);
    }

    public void Add_Product(Product product)
    {
        _products.Add(product);
    }

        public void Add_Product(Product product, double quantity)
    {
        
        product.SetQuantity(quantity);
        _products.Add(product);
    }

    public double Get_Shipping()
    {
        double shipping = 5;
        if (_address.Get_Local())
        {
            return shipping;
        }
        else
        {
            shipping = 35;
            return shipping;
        }
    }
    public void Get_Total()
    {
        double finalTotal = 0;
        foreach (Product item in _products)
        {
            finalTotal += item.Get_Cost();
        }
        Console.WriteLine("-------------------");
        Console.WriteLine($"Cost of products is ${finalTotal}");
        double shipping = Get_Shipping();
        Console.WriteLine($"Shipping cost is ${shipping}");
        finalTotal += shipping;
        Console.WriteLine($"Total cost is ${finalTotal}");
        Console.WriteLine("-------------------");
    }
    public void Shipping_Label()
    {
        Console.WriteLine("---------Shipping Label----------");
        Console.WriteLine($"{_customer.Get_Name()}\n{_address.Get_Address()}");
        Console.WriteLine("---------Shipping Label----------");
    }
    public void Packing_Label()
    {
        Console.WriteLine("---------Packing Label----------");
        foreach (Product item in _products)
        {
            Console.WriteLine($"Name: {item.Get_Product_Name()}");
            Console.WriteLine($"ID #: {item.Get_Product_ID().ToString()}\n");
        }
        Console.WriteLine("---------Packing Label----------");
    }
}