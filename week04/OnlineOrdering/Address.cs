public class Address
{
    //Attributes:
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode = "0";

    //Constructor:
    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public Address(string address, string city, string state, string zipCode, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }
    //Method:
    public bool Get_Local()
    {
        bool local = true;
        if (_country == "US" || _country == "U.S." || _country == "United States" || _country == "USA")
        {
            return local;
        }
        else
        {
            local = false;
            return local;
        }
    }
    public string Get_Address()
    {
        if (_zipCode == "0")
        {
            string FullAddress = $"{_streetAddress}\n{_city}, {_state}\n{_country}";
            return FullAddress;
        }
        else
        {
            string FullAddress = $"{_streetAddress}\n{_city}, {_state} {_zipCode}\n{_country}";
            return FullAddress;
        }
        
    }
}