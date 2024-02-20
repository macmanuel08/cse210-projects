using System;

public class Running : Activity
{
    private double _distance;

    public Running(int minutes,string date,double distance) : base(minutes, date)
    {
        _name = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}