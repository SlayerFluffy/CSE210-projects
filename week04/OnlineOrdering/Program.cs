using System;

class Program
{
    static void Main(string[] args)
    {

        // parameters for new products 
        // (string name, int productID, float price, float quantity)
        Product Milk = new Product("StoreBrand TM Whole Vitamin D Milk", 4358123, 3.58, 1);
        Product Knife = new Product("Camillus Citque 7 inch Folding Pocket Knife", 7562183, 42.00, 1);
        Product Diapers = new Product("Huggies Little Snugglers Baby Diapers", 8008135, 9.94);
        Product Jeans = new Product("Wrangler Men's Slim Straight Fit Jean with Stretch", 4564561, 22.98);
        Product Lego = new Product ("LEGO Ideas Dungeons & Dragons: Red Dragon's Tale Build and Display Set", 2134800, 359.99);

        Address BobAddress = new Address("6919 W. Anniversary Ave.", "Boulder", "CO", "85937", "USA");
        Customer Bob = new Customer("Bob Dylan", BobAddress);
        Order BobOrder = new Order(Bob, BobAddress);

        BobOrder.Add_Product("Huffy Rock Creek Mountain Bicycle", 8645723, 108, 1);
        BobOrder.Add_Product(Milk, 3);
        BobOrder.Add_Product(Lego);

        Address JennyAddress = new Address("5617 Creek Cir.", "Chilliwack", "BC", "V2A 1L1", "CA");
        Customer Jenny = new Customer("Jenny Anderson", JennyAddress);
        Order JennyOrder = new Order(Jenny, JennyAddress);

        JennyOrder.Add_Product(Knife, 6);
        JennyOrder.Add_Product(Diapers, 2);
        JennyOrder.Add_Product(Jeans, 9);

        BobOrder.Packing_Label();
        BobOrder.Shipping_Label();
        BobOrder.Get_Total();

        JennyOrder.Packing_Label();
        JennyOrder.Shipping_Label();
        JennyOrder.Get_Total();   
    }
}