using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the OnlineOrdering Project.");


        Console.Clear();
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);
        Order order1 = new Order(customer1);
        order1.Add_Product(new Product("Laptop", "L123", 1200.50m, 1));
        order1.Add_Product(new Product("Mouse", "M456", 25.75m, 2));

        
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Smith", address2);
        Order order2 = new Order(customer2);
        order2.Add_Product(new Product("Book", "B789", 15.50m, 3));
        order2.Add_Product(new Product("Pen", "P012", 2.25m, 10));

        // List of orders
        List<Order> orders = new List<Order> { order1, order2 };

        // Display results
        foreach (Order order in orders)
        {
            Console.WriteLine(order.Get_PackingLabel());
            Console.WriteLine(order.Get_ShippingLabel());
            Console.WriteLine($"Total Price: ${order.Sum_TTLCost():0.00}");
            Console.WriteLine(new string('=', 40));
        }
    }
    
}