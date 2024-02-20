using System;

public class Swimming : Activity
{
    private double _distance;
    private double _laps;

    public Swimming(int minutes,string date,double distance, double laps) : base(minutes, date)
    {
        _name = "Swimming";
        _distance = distance;
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
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