
using System.Text; // require for StringBuilder

public class Order
{
    Customer _customer;
    List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }
    public void Add_Product(Product product)
    {
        _products.Add(product);
    }
    public decimal Sum_TTLCost()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.Get_TTLCost();
        }

        total += _customer.Is_InUSA() ? 5 : 35; // short cut if ... then 
        return total;
    }
    public void Get_ShippingFee()
    {

    }
    public string Get_PackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Packing Label:");
        foreach (Product product in _products)
        {
            sb.AppendLine($"{product.Name} (ID: {product.ProductId})");
        }
        return sb.ToString();
    }
    public string Get_ShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Shipping Label:");
        sb.AppendLine(_customer.Name);
        sb.AppendLine(_customer.Address.Get_FullAddress());
        return sb.ToString();
    }
}