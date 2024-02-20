using System;

public class Reception : Event
{
    private string _email;
    
    public Reception(string type,string title, string description, string date, string time, Address address,string email) : base(type,title,description,date,time,address)
    {
        _email = email;
    }

    public void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Type: {GetEventType()}");
        Console.WriteLine($"Email for RSVP: {_email}");
    }


}