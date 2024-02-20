using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string type,string title, string description, string date, string time, Address address,string speaker, int capacity) : base(type,title,description,date,time,address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void GetFullDetails()
    {
        GetStandardDetails();
        Console.WriteLine($"Type: {GetEventType()}");
        Console.WriteLine($"Speaker: {_speaker}\nCapacity: {_capacity}");
    }


}