public class Product
{
/* Attributes:
 _name: String
_product_id: int
_price: float
_quantity: int
------------------------------
Constructor:
Product(name:string, _product_id:int, price:float, quantity:int)
------------------------------
Method:
Get_Product():string */

    // Attributes:
    private string _name;
    private double _product_id;
    private double _price;
    private double _quantity;

    // Constructor:
    public Product(string name, double productID, double price, double quantity)
    {
        _name = name;
        _product_id = productID;
        _price = price;
        _quantity = quantity;
    }

        public Product(string name, double productID, double price)
    {
        _name = name;
        _product_id = productID;
        _price = price;
        _quantity = 1;
    }


    // Methods:
    public string Get_Product()
    {
        string product = $"{_name}, {_product_id}, {_price}, {_quantity}";
        return product;
    }

    public void SetQuantity(double quantity)
    {
        _quantity = quantity;
    }

    public string Get_Product_Name()
    {
        return _name;
    }
        public double Get_Product_ID()
    {
        return _product_id;
    }
    public double Get_Cost()
    {
        double total = _price * _quantity;
        return total;
    }
}