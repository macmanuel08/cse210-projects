using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsLivingInUSA()
    {
        string country = _address.GetCountry();
        if (country == "USA" || country == "US")
        {
            return true;
        }
        return false;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }
}