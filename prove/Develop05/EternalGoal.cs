using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        return;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {GetShortName()} ({GetDescription()})";
    }

    public override void RecordEvent()
    {
        return;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{GetShortName()}~~{GetDescription()}~~{GetPoints()}";
    }
}