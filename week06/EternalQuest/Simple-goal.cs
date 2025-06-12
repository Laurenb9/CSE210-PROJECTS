// SimpleGoal.cs - A goal that can be completed once

using System;

class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {Name} ({Description})";

    public override string GetStringRepresentation() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}
