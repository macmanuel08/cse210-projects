using System;

public class Cycling : Activity
{
    private double _distance;

    public Cycling(int minutes,string date,double distance) : base(minutes, date)
    {
        _name = "Cycling";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = _distance / _minutes * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}