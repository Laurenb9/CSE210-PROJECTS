// EternalGoal.cs - A goal that can be recorded unlimited times

using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent() => Points;

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[∞] {Name} ({Description})";

    public override string GetStringRepresentation() => $"EternalGoal|{Name}|{Description}|{Points}";
}
