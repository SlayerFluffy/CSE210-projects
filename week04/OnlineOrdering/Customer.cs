public class Customer
{
    //Attributes:
    private string _name;
    private Address _address;
    
    //Constructor:
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    
    //Method:
    public string Get_Name()
    {
        return _name;
    }
    public bool Get_Local()
    {
        bool local = false;
        local = _address.Get_Local();
        return local;
    }
}