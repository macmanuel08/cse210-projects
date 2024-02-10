using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        string isChecked = "[ ]";
        if (_target == _amountCompleted)
        {
            isChecked = "[X]";
        }

        return $"{isChecked} {GetShortName()} ({GetDescription()}) -- Currently completed {_amountCompleted}/{_target}";
    }

    public override void RecordEvent()
    {
        if (_target != _amountCompleted)
        {
            _amountCompleted++;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }

        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{GetShortName()}~~{GetDescription()}~~{GetPoints()}~~{_bonus}~~{_target}~~{_amountCompleted}";
    }

    public int GetBonus()
    {
        return _bonus;
    }
}