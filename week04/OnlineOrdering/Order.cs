using System.Runtime.InteropServices;

public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    public void AddProduct(Product p)
    {
        _products.Add(p);
    }
    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product p in _products)
        {
            double productTotalCost = p.GetTotalCost();
            totalPrice += productTotalCost;
        }
        int shipping = 0;
        if (_customer.IsInUSA() == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        totalPrice += shipping;
        return totalPrice;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product p in _products)
        {
            string newLine = p.GetProductInfo();
            packingLabel += newLine + "\n";
        }
        return packingLabel;
    }
    public string GetShippingLabel()
    {
        string name = _customer.GetName();
        Address address = _customer.GetAddress();
        string shippingLabel = name + "\n" + address.GetFullAddress();
        return shippingLabel;
    }
}