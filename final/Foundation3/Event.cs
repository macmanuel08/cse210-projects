using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    public Event(string type,string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    public void GetStandardDetails()
    {
        Console.WriteLine($"Title: {_title}\nDescription: {_description}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddress()}");
    }

    public void GetShortDescription()
    {
        Console.WriteLine($"Type: {_type}\nTitle: {_title}\nDate: {_date}");
    }

    public string GetEventType()
    {
        return _type;
    }
}