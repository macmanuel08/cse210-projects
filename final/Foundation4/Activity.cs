using System;

public class Activity
{
    protected string _name;
    protected int _minutes;
    protected string _date;


    public Activity(int minutes, string date)
    {
        _minutes = minutes;
        _date = date;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_minutes} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km");
    }
}