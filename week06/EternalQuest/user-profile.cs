// UserProfile.cs - Stores score, level, and title

using System;

class UserProfile
{
    public int Score { get; private set; }

    public int Level => Score / 100;

    public string Title
    {
        get
        {
            if (Level >= 10) return "Celestial Champion";
            if (Level >= 7) return "Sacred Sage";
            if (Level >= 4) return "Faithful Warrior";
            if (Level >= 1) return "Seeker of Light";
            return "Novice Pilgrim";
        }
    }

    public void AddPoints(int points)
    {
        Score += points;
    }

    public void SetScore(int score)
    {
        Score = score;
    }
}
