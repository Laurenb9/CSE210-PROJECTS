// ChecklistGoal.cs - A goal that requires multiple completions

using System;

class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
                return Points + _bonus;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _currentCount >= _targetCount;

    public override string GetStatus() => $"[{_currentCount}/{_targetCount}] {Name} ({Description})";

    public override string GetStringRepresentation() => $"ChecklistGoal|{Name}|{Description}|{Points}|{_bonus}|{_targetCount}|{_currentCount}";
}
