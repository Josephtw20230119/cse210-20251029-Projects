

public class Product
{
    public string Name { get; }
    public string ProductId { get; }
    public decimal Price { get; }
    public int Quantity { get; }
    public Product(string name, string productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }
    /*public string Get_Name()
    {
        return _name;
    }
    
    public int Get_ProductId()
    {
        return _productId;
    }*/
    public decimal Get_TTLCost()
    {
        return Price * Quantity;   
    }
}