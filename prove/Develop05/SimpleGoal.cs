using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        return;
    }

    public override string GetDetailsString()
    {
        string isChecked = "[ ]";
        if (_isComplete)
        {
            isChecked = "[X]";
        }

        return $"{isChecked} {GetShortName()} ({GetDescription()})";
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{GetShortName()}~~{GetDescription()}~~{GetPoints()}~~{_isComplete}";
    }
}