using System;

public class OutdoorGathering : Event
{
    private string _weather;
    
    public OutdoorGathering(string type,string title, string description, string date, string time, Address address,string weather) : base(type,title,description,date,time,address)
    {
        _weather = weather;
    }

    public void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Type: {GetEventType()}");
        Console.WriteLine($"Weather Statement: {_weather}");
    }


}