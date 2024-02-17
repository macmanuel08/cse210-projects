using System;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private string _packingLabel;
    private string _shippingLabel;
    private int _shippingCost;

    public Order(string name,string street,string city,string state, string country)
    {
        _customer = new Customer(name, street, city, state, country);
        _shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress()}";

        if (_customer.IsLivingInUSA())
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }
    }


    public void AddProduct(string name, string id, int price, int quantity)
    {
        Product product = new Product(name, id, price, quantity);
        _products.Add(product);
    }

    public string GetTotalCost()
    {
        int total = _shippingCost;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        return $"Total Price: {total}";
    }

    public string GetShippingLabel()
    {
        return _shippingLabel;
    }

    public string GetPackingLabel()
    {
        foreach (Product product in _products)
        {
            _packingLabel += $"Product Name: {product.GetName()}, Product ID: {product.GetId()}\n";
        }

        return _packingLabel;
    }
    

}