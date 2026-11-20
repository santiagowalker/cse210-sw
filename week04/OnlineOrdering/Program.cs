using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("145 Pine Street", "Denver", "Colorado", "USA");
        Customer c1 = new Customer("Emma Johnson", a1);
        Product p1 = new Product("Mechanical Keyboard", "MK2000", 79.50, 1);
        Product p2 = new Product("Wireless Mouse", "WM1000", 24.99, 2);
        Product p3 = new Product("USB-C Cable", "UC300", 12.75, 3);
        List<Product> l1 = new List<Product>();
        Order o1 = new Order(l1, c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);
        o1.AddProduct(p3);

        Address a2 = new Address("82 Avenida del Sol", "Buenos Aires", "Buenos Aires", "Argentina");
        Customer c2 = new Customer("Lucas Martinez", a2);
        Product p4 = new Product("Laptop Stand", "LS400", 39.99, 1);
        Product p5 = new Product("Webcam", "WC500", 54.25, 2);
        Product p6 = new Product("Desk Lamp", "DL600", 31.00, 1);
        List<Product> l2 = new List<Product>();
        Order o2 = new Order(l2, c2);
        o2.AddProduct(p4);
        o2.AddProduct(p5);
        o2.AddProduct(p6);

        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"${o1.CalculateTotalPrice():F2}\n");

        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"${o2.CalculateTotalPrice():F2}\n");
    }
}