using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Order 1:");
        Order order1 = new Order("John Doe", "345 Temple Drive", "Filinvest", "Metro Manila", "Philippines");
        order1.AddProduct("Vision Pro", "APP054", 800, 2);
        order1.AddProduct("Meta Quest Pro","MET078", 250, 3);
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotalCost());

        Console.WriteLine("");
        Console.WriteLine("Order 2");
        Order order2 = new Order("Jane Doe", "404 Hacker St.", "Palo Alto", "California", "USA");
        order2.AddProduct("Running Shoes", "SH789", 300, 2);
        order2.AddProduct("Cap","CP101", 80, 3);
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetTotalCost());
    }
}